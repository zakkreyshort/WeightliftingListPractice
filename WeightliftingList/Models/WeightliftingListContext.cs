using Microsoft.EntityFrameworkCore;

namespace WeightliftingList.Models
{
    public class WeightliftingListContext : DbContext
    {
        public WeightliftingListContext(DbContextOptions<WeightliftingListContext> options) : base(options)
        {
        }
        public DbSet<Weight> Weights { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Weight>()
            .HasData(
                new Weight { WeightId = 1, WeightType = "Barbell", Pounds = 45, Material = "Steel", Brand = "Rogue Fitness"},
                new Weight { WeightId = 1, WeightType = "Barbell", Pounds = 45, Material = "Steel", Brand = "Rogue Fitness"},
                new Weight { WeightId = 1, WeightType = "Barbell", Pounds = 45, Material = "Steel", Brand = "Rogue Fitness"},
                new Weight { WeightId = 1, WeightType = "Barbell", Pounds = 45, Material = "Steel", Brand = "Rogue Fitness"},
                new Weight { WeightId = 1, WeightType = "Barbell", Pounds = 45, Material = "Steel", Brand = "Rogue Fitness"}
            );
        }
    }
}

 