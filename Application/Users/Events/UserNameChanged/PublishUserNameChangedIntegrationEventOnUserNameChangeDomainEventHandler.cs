using Application.Core.Abstructions.Messaging;
using Domain.Core.Events;
using Domain.Users.Events;

namespace Application.Users.Events.UserNameChanged;

internal sealed class PublishUserNameChangedIntegrationEventOnUserNameChangeDomainEventHandler : IDomainEventHandler<UserNameChangedDomainEvent>
{
    private readonly IIntegrationEventPublisher _integrationEventPublisher;

    public PublishUserNameChangedIntegrationEventOnUserNameChangeDomainEventHandler(IIntegrationEventPublisher integrationEventPublisher)
    {
        _integrationEventPublisher = integrationEventPublisher;
    }

    public Task Handle(UserNameChangedDomainEvent notification, CancellationToken cancellationToken)
    {
        _integrationEventPublisher.Publish(new UserNameChangedIntegrationEvent(notification));

        return Task.CompletedTask;
    }
}
