using BlazorShop.Models.DTOs;
using System.Net.Http.Json;

namespace BlazorShop.Services
{
    public class ProductService : IProductService
    {
        public HttpClient _httpClient;
        public ILogger<ProductService> _logger;

        public ProductService(HttpClient httpClient, ILogger<ProductService> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<IEnumerable<ProductDTO>> GetItems()
        {
            try
            {
                var productsDTO = await _httpClient.GetFromJsonAsync<IEnumerable<ProductDTO>>("api/products");
                return productsDTO;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while fetching products.");
                throw;
            }
        }
    }
}
