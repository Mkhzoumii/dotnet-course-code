using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Models;
namespace HellowWorld.Data
{
    public class dataContextEF : DbContext
    {
        private string? _conictionString;
        public dataContextEF(){}

        public dataContextEF(IConfiguration config)
        {
            _conictionString = config.GetConnectionString("defaultConnection");
        }
        public DbSet<Computer>? Computer { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer(_conictionString,
               options => options.EnableRetryOnFailure()
                );
            }
        }
        protected override void OnModelCreating(ModelBuilder ModelBuilder)
        {
            ModelBuilder.HasDefaultSchema("TutorialAppSchema");
            ModelBuilder.Entity<Computer>().HasKey(c => c.ComputerId);//ToTable("Computer","TutorialAppSchema");

        }



    }
}
