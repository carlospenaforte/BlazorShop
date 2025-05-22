using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Models.DTOs
{
    public class CarItemAddDTO
    {
        [Required]
        public int CartId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
