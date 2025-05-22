using Commodity_Request_Form.Models;
using Microsoft.EntityFrameworkCore;

namespace Commodity_Request_Form.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<CHA> CHA { get; set; }
        public DbSet<CHW> CHW { get; set; }
        public DbSet<Commodity> Commodity { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // CHW to CHA: many-to-one
            modelBuilder.Entity<CHW>()
            .HasOne(chw => chw.CHA)
            .WithMany(cha => cha.CHWs)
            .HasForeignKey(chw => chw.CHA_ID)
            .OnDelete(DeleteBehavior.Restrict);

            // Commodity to CHW: many-to-one
            modelBuilder.Entity<Commodity>()
                .HasOne(c => c.CHW)
                .WithMany(chw => chw.Commodities)
                .HasForeignKey(c => c.CHW_ID)
                .OnDelete(DeleteBehavior.Restrict);

            // Commodity to CHA: many-to-one
            modelBuilder.Entity<Commodity>()
                .HasOne(c => c.CHA)
                .WithMany(cha => cha.Commodities)
                .HasForeignKey(c => c.CHA_ID)
                .OnDelete(DeleteBehavior.Restrict);

            var seeder = new SeedData();
            seeder.Seed(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
    }

}
