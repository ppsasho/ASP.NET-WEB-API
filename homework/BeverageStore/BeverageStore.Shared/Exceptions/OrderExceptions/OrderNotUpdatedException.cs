namespace BeverageStore.Shared.Exceptions.OrderExceptions
{
    public class OrderNotUpdatedException : Exception
    {
        public OrderNotUpdatedException(string message)
            : base(message)
        {

        }
    }
}
