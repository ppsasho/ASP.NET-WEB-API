namespace BeverageStore.Shared.Exceptions.UserExceptions
{
    public class UserNotCreatedException : Exception
    {
        public UserNotCreatedException(string message)
            : base(message) { }
    }
}
