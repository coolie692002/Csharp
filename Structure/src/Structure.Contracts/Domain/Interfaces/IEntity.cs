﻿namespace Structure.Contracts.Domain.Interfaces;

public interface IEntity
{
    object?[] GetKeys();
}


public interface IEntity<TKey> : IEntity
{
    TKey Id { get; }
}
