﻿using Structure.Contracts.Domain.Interfaces;

namespace Structure.Contracts.Domain;

/// <summary>
/// This class can be used to simplify implementing <see cref="IAuditedObject"/> for aggregate roots.
/// </summary>
[Serializable]
public abstract class AuditedAggregateRoot : CreationAuditedAggregateRoot, IAuditedObject
{
    public virtual DateTime? LastModificationTime { get; set; }
    
    public virtual Guid? LastModifierId { get; set; }
}

/// <summary>
/// This class can be used to simplify implementing <see cref="IAuditedObject"/> for aggregate roots.
/// </summary>
/// <typeparam name="TKey">Type of the primary key of the entity</typeparam>
[Serializable]
public abstract class AuditedAggregateRoot<TKey> : CreationAuditedAggregateRoot<TKey>, IAuditedObject
{
    public virtual DateTime? LastModificationTime { get; set; }
    
    public virtual Guid? LastModifierId { get; set; }

    protected AuditedAggregateRoot()
    {

    }

    protected AuditedAggregateRoot(TKey id)
        : base(id)
    {

    }
}
