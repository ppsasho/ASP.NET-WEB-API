namespace BeverageStore.Shared.Exceptions.UserExceptions
{
    public class UserNotDeletedException : Exception
    {
        public UserNotDeletedException(string message)
            : base(message) { }
    }
}
