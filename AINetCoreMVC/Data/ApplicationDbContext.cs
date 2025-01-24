using Microsoft.EntityFrameworkCore;

namespace AINetCoreMVC.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    
    public DbSet<AINetCoreMVC.Models.Category> Categories { get; set; }
    public DbSet<AINetCoreMVC.Models.Product> Products { get; set; }
}
