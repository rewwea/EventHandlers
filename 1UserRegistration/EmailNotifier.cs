namespace UserRegistration
{
    public class EmailNotifier
    {
        public void OnUserRegistered(string name, string email)
        {
            Console.WriteLine($"New user registered: Name={name}, Email={email}");
        }
    }
}