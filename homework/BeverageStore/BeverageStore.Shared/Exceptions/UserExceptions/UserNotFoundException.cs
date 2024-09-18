namespace BeverageStore.Shared.Exceptions.UserExceptions
{
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException(string message)
            :base (message) { }
    }
}
