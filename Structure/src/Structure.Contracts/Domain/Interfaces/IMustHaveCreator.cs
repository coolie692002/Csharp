﻿using System.Diagnostics.CodeAnalysis;

namespace Structure.Contracts.Domain.Interfaces;


public interface IMustHaveCreator<TCreator> : IMustHaveCreator
{
    [NotNull]
    TCreator Creator { get; }
}

public interface IMustHaveCreator
{
    Guid CreatorId { get; }
}
