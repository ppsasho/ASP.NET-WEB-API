using DTOs.Beverage;

namespace DTOs.OrderItem
{
    public class OrderItemDto
    {
        public int BeverageId { get; set; }
        //public BeverageDto Beverage { get; set; }
        public int Quantity { get; set; }
    }
}
