using IMS.Models;

namespace IMS;

public class IMSContext :DbContext
{
    public DbSet<Product> Products { get; set; } = null;
    public DbSet<Component> Compunents { get; set; } = null;
    public DbSet<ItemPart> ItemParts { get; set; } = null;
    public DbSet<Tool> Tools { get; set; } = null;  

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        global::System.Object value = optionsBuilder.UseSqlServer(#  *ADD CONNECTION HERE*)   ;
    }
}