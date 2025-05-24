using BlazorShop.API.Data;
using BlazorShop.API.Entities;

namespace BlazorShop.API.Repositories
{
    public class ProductRepository : IProductRepositorie
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Product> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetItemsCategory(int id)
        {
            throw new NotImplementedException();
        }
    }
}
