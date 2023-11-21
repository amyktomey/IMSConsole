using IMSonsole;
using Microsoft.EntityFrameworkCore;

namespace IMSConsole;

public class IMSContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Component> Compunents { get; set; }
    public DbSet<ItemPart> ItemParts { get; set; }
    public DbSet<Tool> Tools { get; set; }

    public string DbPath { get; private set; }

    public IMSContext()
    {
        var folder = Environment.SpecialFolder.Desktop;
        var path = Environment.GetFolderPath(folder);
        DbPath = Path.Join(path, "IMS.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite($"Data Source={DbPath}");
    }
}
