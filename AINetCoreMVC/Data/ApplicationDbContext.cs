using Microsoft.EntityFrameworkCore;

namespace AINetCoreMVC.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    
    public DbSet<Models.Category> Categories { get; set; }
    public DbSet<Models.Product> Products { get; set; }
}
