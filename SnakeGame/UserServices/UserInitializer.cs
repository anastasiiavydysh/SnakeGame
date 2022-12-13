namespace SnakeGame.UserServices
{
    public static class UserInitializer
    {
        public static List<User> GetSampleUserDate()
        {
            List<User> users = new List<User>();
            users.Add(new User { Name = "UserName", Score = 10 });
            users.Add(new User { Name = "UserName1", Score = 100 });
            users.Add(new User { Name = "UserName2", Score = 1000 });
            users.Add(new User { Name = "UserName3", Score = 10000 });

            return users;
        }
    }
}
