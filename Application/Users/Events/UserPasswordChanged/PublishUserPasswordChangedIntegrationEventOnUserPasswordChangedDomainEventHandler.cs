using Application.Core.Abstructions.Messaging;
using Domain.Core.Events;
using Domain.Users.Events;

namespace Application.Users.Events.UserPasswordChanged;

internal sealed class PublishUserPasswordChangedIntegrationEventOnUserPasswordChangedDomainEventHandler : IDomainEventHandler<UserPasswordChangedDomainEvent>
{
    private readonly IIntegrationEventPublisher _integrationEventPublisher;

    public PublishUserPasswordChangedIntegrationEventOnUserPasswordChangedDomainEventHandler(IIntegrationEventPublisher integrationEventPublisher)
    {
        _integrationEventPublisher = integrationEventPublisher;
    }

    public Task Handle(UserPasswordChangedDomainEvent notification, CancellationToken cancellationToken)
    {
        _integrationEventPublisher.Publish(new UserPasswordChangedIntegrationEvent(notification));

        return Task.CompletedTask;
    }
}