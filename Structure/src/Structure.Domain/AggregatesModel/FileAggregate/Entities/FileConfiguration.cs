namespace Structure.Domain.AggregatesModel.FileAggregate.Entities;

public class FileConfiguration : FullAuditedEntity<Guid>
{
    public long MaxCapacity { get; set; }
    
    public long MaxFileSize { get; set; }
}
