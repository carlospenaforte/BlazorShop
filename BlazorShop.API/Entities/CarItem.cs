namespace BlazorShop.API.Entities
{
    public class CarItem
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public int CartId { get; set; }
        public int Quantity { get; set; }


        public Product? Product { get; set; }
        public Cart? Cart { get; set; }
    }
}
