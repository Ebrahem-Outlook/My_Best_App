using Application.Core.Abstructions.Messaging;
using Domain.Users.Events;

namespace Application.Users.Events.UserPasswordChanged;

internal sealed class UserPasswordChangedIntegrationEvent : IIntegrationEvent
{
    internal UserPasswordChangedIntegrationEvent(UserPasswordChangedDomainEvent userPasswordChangedDomainEvent)
    {
        UserId = userPasswordChangedDomainEvent.UserId;
    }

    public Guid UserId { get; }
}