using Domain.Core.Events;

namespace Domain.Users.Events
{
    public record UserNameChangedDomainEvent(Guid UserId, string FirstName, string LastName) : IDomainEvent;
}
