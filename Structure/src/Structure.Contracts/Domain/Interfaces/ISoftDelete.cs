using System.Text.Json.Serialization;

namespace Structure.Contracts.Domain.Interfaces;

public interface ISoftDelete
{
    [JsonIgnore]
    bool IsDeleted { get; set; }

    void Delete();
}
