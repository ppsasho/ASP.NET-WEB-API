namespace BeverageStore.Shared.Exceptions.OrderExceptions
{
    public class OrderNotDeletedException : Exception
    {
        public OrderNotDeletedException(string message)
            : base(message)
        {

        }
    }
}
