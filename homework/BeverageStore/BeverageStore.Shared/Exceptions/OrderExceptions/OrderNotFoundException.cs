namespace BeverageStore.Shared.Exceptions.OrderExceptions
{
    public class OrderNotFoundException : Exception
    {
        public OrderNotFoundException(string message)
            :base(message)
        {
            
        }
    }
}
