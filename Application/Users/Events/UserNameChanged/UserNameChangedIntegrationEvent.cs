using Application.Core.Abstructions.Messaging;
using Domain.Users.Events;

namespace Application.Users.Events.UserNameChanged;

internal sealed class UserNameChangedIntegrationEvent : IIntegrationEvent
{
    internal UserNameChangedIntegrationEvent(UserNameChangedDomainEvent userNameChangedDomainEvent)
    {
        UserId = userNameChangedDomainEvent.UserId;
    }

    public Guid UserId { get; }
}
