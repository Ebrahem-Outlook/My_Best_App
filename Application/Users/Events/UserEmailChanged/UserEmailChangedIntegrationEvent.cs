using Application.Core.Abstructions.Messaging;
using Domain.Users.Events;

namespace Application.Users.Events.UserEmailChanged;

public sealed class UserEmailChangedIntegrationEvent : IIntegrationEvent
{
    public UserEmailChangedIntegrationEvent(UserEmailChangedDomainEvent userEmailChangedDomainEvent)
    {
        UserId = userEmailChangedDomainEvent.UserId;
    }

    public Guid UserId { get; }
}
