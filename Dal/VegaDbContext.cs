using Microsoft.EntityFrameworkCore;
using Vega.Models;

namespace Vega.Dal
{
    public class VegaDbContext : DbContext
    {
   
        public DbSet<Make> Makes  { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Feature> Features { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehcileFeature> VehicleFeatures  { get; set; }
        
             public VegaDbContext(DbContextOptions<VegaDbContext> options)
        :base(options)
        {
            
        }
         protected override void OnModelCreating(ModelBuilder modelBuilder)
             {
                 modelBuilder.Entity<VehcileFeature>().HasKey
                 (VF => new {VF.VehicleId,VF.FeatureId});
                    
                modelBuilder.Entity<VehcileFeature>()
                .HasOne(VF => VF.Vehicle)
                .WithMany(v => v.Features)
                .HasForeignKey(VF => VF.VehicleId)
                .OnDelete(DeleteBehavior.Restrict);

                
             }
    }
}       