using System;

namespace DelegateExample
{
    public class AccountController
    {
        public delegate void ServiceLogin(User user);
        public void Login(User user, ServiceLogin serviceLogin)
        {
            var isExist = user.UserValidate(user);
            Console.WriteLine(isExist);

            if (isExist)
            {
                serviceLogin(user);
            }
        }

        public void Register(User user, Action<User> serviceLogin)
        {
            Console.WriteLine("User registration successfully");

            serviceLogin(user);
        }
    }
}
