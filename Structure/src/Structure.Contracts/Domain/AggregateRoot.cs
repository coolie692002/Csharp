﻿using System.ComponentModel.DataAnnotations;
using Structure.Contracts.Domain.Interfaces;

namespace Structure.Contracts.Domain;

[Serializable]
public abstract class AggregateRoot : BasicAggregateRoot,
    IHasConcurrencyStamp
{
    [DisableAuditing]
    public string ConcurrencyStamp { get; set; } = Guid.NewGuid().ToString("N");
}

[Serializable]
public abstract class AggregateRoot<TKey> : BasicAggregateRoot<TKey>
{
    [DisableAuditing]
    public string ConcurrencyStamp { get; set; }

    protected AggregateRoot()
    {
        ConcurrencyStamp = Guid.NewGuid().ToString("N");
    }

    protected AggregateRoot(TKey id)
        : base(id)
    {
        ConcurrencyStamp = Guid.NewGuid().ToString("N");
    }
}
