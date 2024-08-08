namespace UsersAPI
{
    public static class UserDb
    {
        public static List<User> Users = new()
        {
            new User
            {
                Id = 1,
                Username = "FirstUser",
            }
        };
    }
}
