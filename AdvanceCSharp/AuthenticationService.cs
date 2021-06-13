using System;

namespace DelegateExample
{
    public class AuthenticationService
    {
        public void Login(User user)
        {
            Console.WriteLine("User Login successfully");
        }

        public void GoogleLogin(User user)
        {
            Console.WriteLine("Login to google");
        }

        public void LoginToYahoo(User user)
        {
            Console.WriteLine("Login to Yahoo");
        }

        public void LoginToMicrosoft(User user)
        {
            Console.WriteLine("Login to Microsoft");
        }
    }
}
