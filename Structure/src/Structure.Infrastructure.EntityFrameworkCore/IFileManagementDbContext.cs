using Microsoft.EntityFrameworkCore;
using Structure.Domain.AggregatesModel.FileAggregate.Entities;
using File = Structure.Domain.AggregatesModel.FileAggregate.Entities.File;

namespace Structure.Infrastructure.EntityFrameworkCore;

public interface IFileManagementDbContext 
{
    DbSet<File> Files { get; set; }
    DbSet<LockedFile> LockedFiles { get; set; }
    DbSet<FileConfiguration>  FileConfigurations { get; set; }
}
