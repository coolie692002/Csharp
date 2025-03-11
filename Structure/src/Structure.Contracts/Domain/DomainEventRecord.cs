﻿using MediatR;

namespace Structure.Contracts.Domain;

public class DomainEventRecord(object eventData, long eventOrder) : INotification
{
    public object EventData { get; } = eventData;

    public long EventOrder { get; } = eventOrder;
    
    public DateTime DateOccurred { get; protected set; } = DateTime.UtcNow;
}
