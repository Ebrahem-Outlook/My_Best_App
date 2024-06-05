using Application.Core.Abstructions.Messaging;
using Domain.Core.Events;
using Domain.Users.Events;

namespace Application.Users.Events.UserEmailChanged;

internal sealed class PublishUserEmailChangedIntegrationEventOnUserEmailChangedDomainEventHandler : IDomainEventHandler<UserEmailChangedDomainEvent>
{
    private readonly IIntegrationEventPublisher _integrationEventPublisher;

    public PublishUserEmailChangedIntegrationEventOnUserEmailChangedDomainEventHandler(IIntegrationEventPublisher integrationEventPublisher)
    {
        _integrationEventPublisher = integrationEventPublisher;
    }

    public Task Handle(UserEmailChangedDomainEvent notification, CancellationToken cancellationToken)
    {
        _integrationEventPublisher.Publish(new UserEmailChangedIntegrationEvent(notification));

        return Task.CompletedTask;  
    }
}