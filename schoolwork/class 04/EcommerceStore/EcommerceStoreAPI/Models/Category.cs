namespace EcommerceStoreAPI.Models
{
    public class Category : Base
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Product> Products { get; set; }

    }
}
