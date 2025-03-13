using Structure.Contracts.Domain.Interfaces;

namespace Structure.Contracts.Domain;

[Serializable]
public abstract class CreationAuditedAggregateRootWithUser<TUser> : CreationAuditedAggregateRoot, ICreationAuditedObject<TUser>
{
    public virtual TUser? Creator { get; protected set; }
}

[Serializable]
public abstract class CreationAuditedAggregateRootWithUser<TKey, TUser> : CreationAuditedAggregateRoot<TKey>, ICreationAuditedObject<TUser>
{
    public virtual TUser? Creator { get; protected set; }

    protected CreationAuditedAggregateRootWithUser()
    {

    }

    protected CreationAuditedAggregateRootWithUser(TKey id)
        : base(id)
    {

    }
}
