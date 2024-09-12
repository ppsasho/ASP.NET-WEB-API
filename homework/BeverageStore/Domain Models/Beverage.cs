namespace Domain_Models
{
    public class Beverage : Base
    {
        public string Name { get; set; }
        public Type Type { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
