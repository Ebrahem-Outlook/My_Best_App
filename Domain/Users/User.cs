using Domain.Core.Premitives;
using Domain.Users.Events;

namespace Domain.Users
{
    public sealed class User : AggregateRoot
    {
        public User(string firstName, string lastName, string email, string password) : base(Guid.NewGuid())
        {
            FirstName = firstName ?? throw new ArgumentNullException();

            LastName = lastName ?? throw new ArgumentNullException();

            Email = email ?? throw new ArgumentNullException();

            Password = password ?? throw new ArgumentNullException();
        }

        public User() { }

        public string FirstName { get; private set; } = string.Empty;

        public string LastName { get; private set; } = string.Empty;

        public string Email { get; private set; } = string.Empty;

        public string Password { get; private set; } = string.Empty;

        public static User Create(string firstName, string lastName, string email, string password)
        {
            var user = new User(firstName, lastName, email, password);

            user.AddDomainEvent(new UserCreatedDomainEvent(user.Id, user.FirstName, user.LastName, user.Email, user.Password));

            return user;
        }

        public void ChangeName(string firstName, string lastName)
        {
            FirstName = firstName ?? throw new ArgumentNullException();

            LastName = lastName ?? throw new ArgumentNullException();
        }

        public void ChangeEmail(string email)
        {
            Email = email ?? throw new ArgumentNullException();
        }

        public void ChangePassword(string password)
        {
            Password = password ?? throw new ArgumentNullException();
        }
    }
}
