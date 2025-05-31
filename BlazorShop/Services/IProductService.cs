using BlazorShop.Models.DTOs;

namespace BlazorShop.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetItems();
    }
}
