namespace DomainModels
{
    public class Category : Base
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
