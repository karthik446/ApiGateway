namespace Actio.Common.Events
{
    public class UserCreated : IEvent
    {
        public UserCreated(string email, string name)
        {
            this.Email = email;
            this.Name = name;

        }

        protected UserCreated()
        {

        }
        public string Email { get; }
        public string Name { get; }

    }
}