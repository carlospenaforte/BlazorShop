using BlazorShop.Models.DTOs;

namespace BlazorShop.Services
{
    public class ProductService : IProductService
    {
        public Task<IEnumerable<ProductDTO>> GetItems()
        {
            // This method should return a list of products.
            // For now, we will return an empty list.
            return Task.FromResult<IEnumerable<ProductDTO>>(new List<ProductDTO>());
        }
    }
}
