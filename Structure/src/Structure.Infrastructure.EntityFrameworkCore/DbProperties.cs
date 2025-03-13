namespace Structure.Infrastructure.EntityFrameworkCore;

public static class DbProperties
{
    public static string DbTablePrefix { get; set; } = "Structure";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "DefaultConnection";
}
