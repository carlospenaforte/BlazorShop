namespace BlazorShop.API.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;


        public Cart? Cart { get; set; }
    }
}
