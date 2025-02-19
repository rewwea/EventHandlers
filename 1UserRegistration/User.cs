using System;

namespace UserRegistration
{
    public class User
    {
        public event Action<string, string> UserRegistered;

        public string Name { get; private set; }
        public string Email { get; private set; }

        public void Register(string name, string email)
        {
            Name = name;
            Email = email;
            OnUserRegistered(name, email);
        }

        protected virtual void OnUserRegistered(string name, string email)
        {
            UserRegistered?.Invoke(name, email);
        }
    }
}