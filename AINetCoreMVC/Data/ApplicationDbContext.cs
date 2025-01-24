using Microsoft.EntityFrameworkCore;

namespace AINetCoreMVC.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    
    // Add DbSet properties for your entities here
    // Example: public DbSet<MyEntity> MyEntities { get; set; }
}
