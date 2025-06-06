﻿namespace BlazorShop.API.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public string UserId { get; set; } = string.Empty;

        public ICollection<CarItem> Items { get; set; } = new List<CarItem>();
    }
}
