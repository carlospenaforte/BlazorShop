namespace BlazorShop.Models.DTOs
{
    public class CarItemDTO
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CartId { get; set; }
        public int Quantity { get; set; }


        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public string? ProductImageURL { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ProductTotalPrice { get; set; }
    }
}
