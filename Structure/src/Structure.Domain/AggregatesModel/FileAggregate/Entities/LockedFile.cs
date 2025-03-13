namespace Structure.Domain.AggregatesModel.FileAggregate.Entities;

public class LockedFile : FullAuditedEntity<Guid>
{
    public Guid FileId { get; set; }
    
    public bool EnabledLock { get; set; }

    public string Password { get; set; }
    
    internal LockedFile(Guid fileId, string password)
    {
        FileId = fileId;
        Password = password;
        EnabledLock = false; 
    }

    public void LockFile()
    {
        EnabledLock = true;
    }
    
    public void UnlockFile(string password)
    {
        if (password == Password)
        {
            throw new IncorrectPasswordFileException();
        }
        EnabledLock = false;
    }
    
    public void ChangePassword(string newPassword)
    {
        Password = newPassword;
    }
}
