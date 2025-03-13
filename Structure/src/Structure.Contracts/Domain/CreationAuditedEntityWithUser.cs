using Structure.Contracts.Domain.Interfaces;

namespace Structure.Contracts.Domain;

[Serializable]
public abstract class CreationAuditedEntityWithUser<TUser> : CreationAuditedEntity, ICreationAuditedObject<TUser>
{
    public virtual TUser? Creator { get; protected set; }
}

[Serializable]
public abstract class CreationAuditedEntityWithUser<TKey, TUser> : CreationAuditedEntity<TKey>, ICreationAuditedObject<TUser>
{
    public virtual TUser? Creator { get; protected set; }

    protected CreationAuditedEntityWithUser()
    {

    }

    protected CreationAuditedEntityWithUser(TKey id)
        : base(id)
    {

    }
}
