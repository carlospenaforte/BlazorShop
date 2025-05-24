using BlazorShop.API.Data;
using BlazorShop.API.Entities;
using Microsoft.EntityFrameworkCore;

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
            var product = await _context.Products
                        .Include(c => c.Category)
                        .SingleOrDefaultAsync(c => c.Id == id);

            return product;
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await _context.Products
                        .Include(p => p.Category)
                        .ToListAsync();

            return products;
        }

        public async Task<IEnumerable<Product>> GetItemsCategory(int id)
        {
            var products = await _context.Products
                        .Include(p => p.Category)
                        .Where(p => p.CategoryId == id).ToListAsync();

            return products;
        }
    }
}
