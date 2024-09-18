namespace BeverageStore.Shared.Exceptions.BeverageExceptions
{
    public class BeverageNotDeletedException : Exception
    {
        public BeverageNotDeletedException(string message)
            : base (message)
        {
            
        }
    }
}
