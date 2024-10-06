using System.Net.Http.Headers;
using System.Text;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using VSDCAPIApiClient.DTOs;

namespace VSDCAPI
{
    public class VSDCAPIApiClient : IVSDCAPIApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<VSDCAPIApiClient> _logger;
        private readonly string _currentUrl = "localhost:8080/zrasandboxvsdc";
        public VSDCAPIApiClient(HttpClient httpClient, ILogger<VSDCAPIApiClient> logger)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri($"http://{_currentUrl}/");
            _logger = logger;
        }

        public async Task<Stream> TestServerRunning()
        {
            try
            {
                var response = await _httpClient.GetAsync($"");
                return await response.Content.ReadAsStreamAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "TestServerRunning");
                throw;
            }
        }
    
        public async Task<ZraResponse?> DeviceInitialization(DeviceInitializationRequest request)
        {
            try
            {
                // get the response
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"initializer/selectInitInfo", request);

                // Ensure the response is successful
                response.EnsureSuccessStatusCode();

                // Read the content as a string
                var contentString = await response.Content.ReadAsStringAsync();

                // Deserialize the content
                var responseDeserialized = JsonConvert.DeserializeObject<ZraResponse>(contentString);

                // Convert the string back to a stream
                return responseDeserialized;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "DeviceInitialization");
                throw;
            }
        }
    
        public async Task<Stream> GetUnitsOfMeasure(GetUnitsOfMeasureRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"code/selectCodes", request);
                return await response.Content.ReadAsStreamAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GetUnitsOfMeasure");
                throw;
            }
        }
    
        public async Task<Stream> ClassificationCodes(GetUnitsOfMeasureRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"itemClass/selectItemsClass", request);
                return await response.Content.ReadAsStreamAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "ClassificationCodes");
                throw;
            }
        }
    
        public async Task<Stream> Notices(GetUnitsOfMeasureRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"notices/selectNotices", request);
                return await response.Content.ReadAsStreamAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Notices");
                throw;
            }
        }
    
        public async Task<Stream> Branches(GetUnitsOfMeasureRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"branches/selectBranches", request);
                return await response.Content.ReadAsStreamAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Branches");
                throw;
            }
        }
    
        public async Task<Stream> GetItems(GetUnitsOfMeasureRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"items/selectItems", request);
                return await response.Content.ReadAsStreamAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GetItems");
                throw;
            }
        }
    
        public async Task<Stream> Customers(CustomersRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"customers/selectCustomer", request);
                return await response.Content.ReadAsStreamAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Customers");
                throw;
            }
        }
    
        public async Task<Stream> SaveStockMaster(SaveStockMasterRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"stockMaster/saveStockMaster", request);
                return await response.Content.ReadAsStreamAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "SaveStockMaster");
                throw;
            }
        }
    
        public async Task<Stream> GetPurchases(CustomersRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"trnsPurchase/selectTrnsPurchaseSales", request);
                return await response.Content.ReadAsStreamAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GetPurchases");
                throw;
            }
        }
    
        public async Task<Stream> GetStockItems(CustomersRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"stock/selectStockItems", request);
                return await response.Content.ReadAsStreamAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GetStockItems");
                throw;
            }
        }
    
        public async Task<Stream> SaveStockItem(SaveStockItemRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"stock/saveStockItems", request);
                return await response.Content.ReadAsStreamAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error");
                throw;
            }
        }
    
        public async Task<Stream> SavePurchases(SavePurchasesRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"trnsPurchase/savePurchase", request);
                return await response.Content.ReadAsStreamAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error");
                throw;
            }
        }
    
        public async Task<Stream> SelectInvoice(SelectInvoiceRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"trnsSales/selectInvoice", request);
                return await response.Content.ReadAsStreamAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error");
                throw;
            }
        }
    
        public async Task<Stream> SaveSales(SaveSalesRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"trnsSales/saveSales", request);
                return await response.Content.ReadAsStreamAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error");
                throw;
            }
        }
    
        public async Task<Stream> UpdateImportItems(UpdateImportItemsRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"imports/updateImportItems", request);
                return await response.Content.ReadAsStreamAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error");
                throw;
            }
        }
    
        public async Task<Stream> GetImports(GetImportsRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"imports/selectImportItems", request);
                return await response.Content.ReadAsStreamAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error");
                throw;
            }
        }
    
        public async Task<Stream> GetItems2(CustomersRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"items/selectItems", request);
                return await response.Content.ReadAsStreamAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error");
                throw;
            }
        }
    
        public async Task<Stream> SaveItemComposition(SaveItemCompositionRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"items/saveItemComposition", request);
                return await response.Content.ReadAsStreamAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error");
                throw;
            }
        }
    
        public async Task<Stream> UpdateItem(UpdateItemRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"items/updateItem", request);
                return await response.Content.ReadAsStreamAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error");
                throw;
            }
        }
    
        public async Task<Stream> SaveItems(UpdateItemRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"items/saveItem", request);
                return await response.Content.ReadAsStreamAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error");
                throw;
            }
        }
    
        public async Task<Stream> BranchCustomers(BranchCustomersRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"branches/saveBrancheCustomers", request);
                return await response.Content.ReadAsStreamAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error");
                throw;
            }
        }
    
        public async Task<Stream> BranchUser(BranchUserRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"branches/saveBrancheUser", request);
                return await response.Content.ReadAsStreamAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error");
                throw;
            }
        }
    
        public async Task<Stream> DeviceInitializationTest(DeviceInitializationRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsNewtonsoftJsonAsync($"initializer/selectInitInfo", request);
                return await response.Content.ReadAsStreamAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error");
                throw;
            }
        }
    }
}