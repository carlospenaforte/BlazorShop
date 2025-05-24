using BlazorShop.API.Entities;
using BlazorShop.Models.DTOs;

namespace BlazorShop.API.Mappings
{
    public static class MappingDTOs
    {
        public static IEnumerable<CategoryDTO> ConvertCategoryToDTO(
            this IEnumerable<Category> categories)
        {
            return (from cateogie in categories select new CategoryDTO
            {
                Id = cateogie.Id,
                Name = cateogie.Name,
                IconCSS = cateogie.IconCSS,
            }).ToList();
        }

        public static IEnumerable<ProductDTO> ConvertProductsToDTO(
            this IEnumerable<Product> products)
        {
            return (from product in products
                    select new ProductDTO
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Description = product.Description,
                        Price = product.Price,
                        ImageURL = product.ImageURL,
                        Quantity = product.Quantity,
                        CategoryId = product.Category.Id,
                        CategoryName = product.Category.Name,
                    }).ToList();
        }
    }
}
