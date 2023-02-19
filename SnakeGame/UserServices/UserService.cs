using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.UserServices
{
    public class UserService //реализация интерфейсов
    {
        List<User> _users = new List<User>();
        public UserService()
        {
            _users = UserInitializer.GetSampleUserDate();
        }

        private IEnumerable<User> GetAllUsers()
        {
            return _users.OrderByDescending(x=>x.Score);
        }

        public void DisplayAllUsers()
        {
            Console.WriteLine("Results");
            foreach(var user in GetAllUsers())
            {
                Console.WriteLine($"{user.Name} with score: {user.Score}");
            }
            Console.WriteLine("Press Backspace to back");
        }

        private User CreateUser(string name)
        {
            User user = new User();

            var existUsers = _users.Select(x => x.Name);
            try
            {
                if (existUsers.Contains(name))
                    throw new ArgumentException("The user exist");
            }
            catch(Exception ex)
            {
                throw ex;
            }
            user.Name = name;

            _users.Add(user);
            return user;
        }

        public User EnterNewUser()
        {
            Console.Write("Enter your name -> ");
            string userName = Console.ReadLine();
            User user = new User();
            while (String.IsNullOrWhiteSpace(userName))
            {
                Console.WriteLine("Enter your name -> ");
                userName = Console.ReadLine();
            }
            try
            {
                user = CreateUser(userName);
                Console.WriteLine("The user was created");  
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
            Console.WriteLine("Press Backspace to back");
            return user;
        }
    }
}
