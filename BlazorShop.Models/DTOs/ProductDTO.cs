using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorShop.Models.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageURL { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }

        public string CategoryName { get; set; } = string.Empty;
    }
}
