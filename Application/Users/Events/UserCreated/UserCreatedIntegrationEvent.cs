using Application.Core.Abstructions.Messaging;
using Domain.Users.Events;

namespace Application.Users.Events.UserCreated;

public sealed class UserCreatedIntegrationEvent :  IIntegrationEvent
{
    internal UserCreatedIntegrationEvent(UserCreatedDomainEvent userCreatedDomainEvent)
    {
        UserId = userCreatedDomainEvent.UserId;
    }

    public Guid UserId { get; }
}
