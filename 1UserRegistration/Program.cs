using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            var notifier = new EmailNotifier();

            user.UserRegistered += notifier.OnUserRegistered;

            user.Register("John Doe", "john.doe@example.com");
        }
    }
}