using MediatR;

namespace Application.Core.Abstructions.Messaging
{
    public interface IEventHandler<in TEvent> : INotificationHandler<TEvent> where TEvent : IEvent;
}
