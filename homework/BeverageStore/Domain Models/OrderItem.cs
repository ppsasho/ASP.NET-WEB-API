namespace Domain_Models
{
    public class OrderItem : Base
    {
        public int BeverageId { get; set; }
        public Beverage Beverage { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
