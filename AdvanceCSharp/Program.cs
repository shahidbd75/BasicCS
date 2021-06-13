using System;

namespace DelegateExample
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountController accountController = new AccountController();
            
            User usr = new User
            {
                Id = 1,
                Password = "123456789",
                Username = "Jon doe",
                RoleName = "Admin"
            };

            AccountController.ServiceLogin serviceLogin = Authenticate;

            Action<User> otherLogin = Authenticate;

            AuthenticationService authenticationService = new AuthenticationService();
            
            serviceLogin += authenticationService.Login;
            
            serviceLogin += authenticationService.LoginToYahoo;
            serviceLogin += authenticationService.LoginToMicrosoft;

            accountController.Login(usr,serviceLogin);

            otherLogin += authenticationService.LoginToMicrosoft;
            accountController.Register(usr,otherLogin);
            Console.ReadKey();

            
        }

        static void Authenticate(User user)
        {
            Console.WriteLine("Authenticated successfully");
        }
    }
}
