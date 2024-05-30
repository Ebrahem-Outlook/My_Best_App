using Domain.Core.Events;

namespace Domain.Core.Premitives
{
    public abstract class AggregateRoot : Entity
    {
        protected AggregateRoot(Guid id) : base(id) { }

        protected AggregateRoot() : base() { }

        private List<IDomainEvent> domainEvents = new List<IDomainEvent>();

        public IReadOnlyCollection<IDomainEvent> DomainEvents => domainEvents.AsReadOnly();

        protected void AddDomainEvent(IDomainEvent @event) => domainEvents.Add(@event);

        protected void Clear() => domainEvents.Clear();
    }
}
