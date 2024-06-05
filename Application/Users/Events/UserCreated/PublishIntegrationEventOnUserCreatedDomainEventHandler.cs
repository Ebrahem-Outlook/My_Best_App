using Application.Core.Abstructions.Messaging;
using Domain.Core.Events;
using Domain.Users.Events;

namespace Application.Users.Events.UserCreated;

internal class PublishIntegrationEventOnUserCreatedDomainEventHandler : IDomainEventHandler<UserCreatedDomainEvent>
{
    private readonly IIntegrationEventPublisher _integrationEventPublisher;

    public PublishIntegrationEventOnUserCreatedDomainEventHandler(IIntegrationEventPublisher integrationEventPublisher)
    {
        _integrationEventPublisher = integrationEventPublisher;
    }

    public async Task Handle(UserCreatedDomainEvent notification, CancellationToken cancellationToken)
    {
        _integrationEventPublisher.Publish(new UserCreatedIntegrationEvent(notification));

        await Task.CompletedTask;
    }
}