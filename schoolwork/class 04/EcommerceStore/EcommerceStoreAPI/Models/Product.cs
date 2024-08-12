﻿namespace EcommerceStoreAPI.Models
{
    public class Product : Base
    {
        public string Name { get; set; }
        public string Description{ get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public IEnumerable<Review> Reviews { get; set; }
    }
}
