using DataLayer.Models;
using DataLayer.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using VSDCAPI;
using VSDCAPIApiClient;

////this is the code to initialize the application automatically
//var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddDbContext<AppDBContext>(options => options.UseSqlServer("Server=localhost; Database=EVO-CHEM; User Id=sa; Password=Hackproof123; Trust Server Certificate=true;"));
//builder.Services.AddScoped<IFiscalInfoService, FiscalInfoService>();
//builder.Services.AddScoped<IVSDCAPIApiClient, VSDCAPI.VSDCAPIApiClient>();
//builder.Services.AddHostedService<TimerService>();
//var app = builder.Build();
//app.Run();

//Run the calls here
//all the code below will be deleted in favor of the syntax above
Console.WriteLine("Hello, World! This is the VSDCAPI");
using ILoggerFactory factory = LoggerFactory.Create(builder =>
{
    builder.AddConsole();
});
ILogger<VSDCAPI.VSDCAPIApiClient> logger = factory.CreateLogger<VSDCAPI.VSDCAPIApiClient>();

HttpClient httpClient = new HttpClient();
var client = new VSDCAPI.VSDCAPIApiClient(httpClient, logger);

Console.WriteLine("Running the Test call! This is the VSDCAPI");
await client.TestServerRunning();

var request = new DeviceInitializationRequest
{
    Tpin = "1002546945",
    BhfId = "000",
    DvcSrlNo = "CHC-EVO"
};

var zraResponse = await client.DeviceInitialization(request);

Console.WriteLine(zraResponse!.ToString());


//steps to fiscalise invoices
var fiscalService = new FiscalInfoService(new AppDBContext());

var invoices = await fiscalService.GetZraInvoicesAsync();

foreach (var invoice in invoices)
{
    var saveInvoices = DataMapper.ConvertInvoice(invoice);
    var response = await client.SaveSales(saveInvoices);

    //if response is OK THEN save items
    foreach(var item in saveInvoices.ItemList)
    {
        var updateRequest = DataMapper.MapToUpdateItemRequest(item);
        var itemResponse = await client.SaveItems(updateRequest);
    }

}





