namespace Application.Core.Abstructions.Messaging
{
    public interface IIntegrationEventPublisher
    {
        void Publish(IIntegrationEvent integrationEvent);
    }
}
