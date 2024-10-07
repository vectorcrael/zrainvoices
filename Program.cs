using DataLayer.Models;
using DataLayer.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VSDCAPI;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddDbContext<AppDBContext>(options => options.UseSqlServer("Server=localhost; Database=EVO-CHEM; User Id=sa; Password=Hackproof123; Trust Server Certificate=true;"));
builder.Services.AddScoped<IFiscalInfoService, FiscalInfoService>();
builder.Services.AddScoped<HttpClient, HttpClient>();
builder.Services.AddScoped<IVSDCAPIApiClient, VSDCAPI.VSDCAPIApiClient>();
builder.Services.AddHostedService<TimerService>();
var app = builder.Build();
app.Run();