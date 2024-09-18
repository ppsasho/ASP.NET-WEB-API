namespace BeverageStore.Shared.Exceptions.BeverageExceptions
{
    public class BeverageNotFoundException : Exception
    {
        public BeverageNotFoundException(string message)
            :base(message) { }
    }
}
