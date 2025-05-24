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

        public static ProductDTO ConvertProductToDTO(
            this Product product)
        {
            return new ProductDTO
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                ImageURL = product.ImageURL,
                Quantity = product.Quantity,
                CategoryId = product.Category.Id,
                CategoryName = product.Category.Name,
            };
        }

        public static IEnumerable<CarItemDTO> ConvertCarItemsToDTO(
            this IEnumerable<CarItem> carItems, IEnumerable<Product> products)
        {
            return (from CarItem in carItems
                    join product in products
                    on CarItem.ProductId equals product.Id
                    select new CarItemDTO
                    {
                        Id = CarItem.Id,
                        ProductId = CarItem.ProductId,
                        ProductName = product.Name,
                        ProductDescription = product.Description,
                        ProductImageURL = product.ImageURL,
                        ProductPrice = product.Price,
                        CartId = CarItem.CartId,
                        Quantity = CarItem.Quantity,
                        ProductTotalPrice = product.Price * CarItem.Quantity,
                    }).ToList();
        }

        public static CarItemDTO ConvertCarItemToDTO(
            this CarItem carItem, Product product)
        {
            return new CarItemDTO
            {
                Id = carItem.Id,
                ProductId = carItem.ProductId,
                ProductName = product.Name,
                ProductDescription = product.Description,
                ProductImageURL = product.ImageURL,
                ProductPrice = product.Price,
                CartId = carItem.CartId,
                Quantity = carItem.Quantity,
                ProductTotalPrice = product.Price * carItem.Quantity,
            };
        }
    }
}
