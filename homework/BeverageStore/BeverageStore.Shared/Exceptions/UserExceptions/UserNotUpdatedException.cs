namespace BeverageStore.Shared.Exceptions.UserExceptions
{
    public class UserNotUpdatedException : Exception
    {
        public UserNotUpdatedException(string message)
            : base(message) { }
    }
}
