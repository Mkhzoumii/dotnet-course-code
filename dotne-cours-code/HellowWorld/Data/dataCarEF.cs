using Microsoft.EntityFrameworkCore;
using Models;
namespace dataCarEF2;
public class dataCarEF : DbContext
{
    public DbSet<Car>? car { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        if (!options.IsConfigured)
        {
            options.UseSqlServer("server=localhost;database=DotNetCourseDatabase;trustservercertificate=true;trusted_connection=true;", options => options.EnableRetryOnFailure());
        }
    
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("TutorialAppSchema");
        modelBuilder.Entity<Car>().HasKey(c=>c.carId);
    }


}