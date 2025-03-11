﻿namespace Structure.Contracts.Domain.Interfaces;

public interface IMayHaveCreator<TCreator>
{
    TCreator? Creator { get; }
}

public interface IMayHaveCreator
{
    Guid? CreatorId { get; }
}
