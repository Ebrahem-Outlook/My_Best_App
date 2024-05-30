using Domain.Core.Events;

namespace Domain.Users.Events
{
    public record UserCreatedDomainEvent(Guid UserId, string FirstName, string LastName, string Email, string Password) : IDomainEvent;
}
