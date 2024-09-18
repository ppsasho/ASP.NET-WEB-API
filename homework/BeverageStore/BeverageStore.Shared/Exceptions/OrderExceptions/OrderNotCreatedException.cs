namespace BeverageStore.Shared.Exceptions.OrderExceptions
{
    public class OrderNotCreatedException : Exception
    {
        public OrderNotCreatedException(string message)
            : base(message)
        {

        }
    }
}
