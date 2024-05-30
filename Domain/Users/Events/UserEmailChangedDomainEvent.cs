using Domain.Core.Events;

namespace Domain.Users.Events
{
    public record UserEmailChangedDomainEvent(Guid UserId, string Email) : IDomainEvent;
}
