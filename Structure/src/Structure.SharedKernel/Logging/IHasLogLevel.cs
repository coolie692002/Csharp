using Microsoft.Extensions.Logging;

namespace Structure.SharedKernel.Logging;

public interface IHasLogLevel
{
    LogLevel LogLevel { get; set; }
}
