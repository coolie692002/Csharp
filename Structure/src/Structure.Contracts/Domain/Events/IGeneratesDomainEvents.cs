namespace Structure.Contracts.Domain.Events;

public interface IGeneratesDomainEvents
{
    public void RegisterDomainEvent(DomainEventRecord record);

    public void RemoveDomainEvent(DomainEventRecord record);

    public void ClearDomainEvents();
}
