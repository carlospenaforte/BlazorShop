using BlazorShop.API.Entities;

namespace BlazorShop.API.Repositories
{
    public interface IProductRepositorie
    {
        Task<IEnumerable<Product>> GetItems();
        Task<Product> GetItem(int id);
        Task<IEnumerable<Product>> GetItemsCategory(int id);
    }
}
