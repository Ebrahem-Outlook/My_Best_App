using Domain.Core.Events;

namespace Domain.Users.Events
{
    public record UserPasswordChangedDomainEvent(Guid UserId, string Password) : IDomainEvent;
}
