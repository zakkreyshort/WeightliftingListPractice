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
                new Weight { WeightId = 2, WeightType = "Dumbbell", Pounds = 25, Material = "Steel", Brand = "Rogue Fitness"},
                new Weight { WeightId = 3, WeightType = "Kettlebell", Pounds = 40, Material = "Coated Steel", Brand = "Rogue Fitness"},
                new Weight { WeightId = 4, WeightType = "Ez Curl Bar", Pounds = 20, Material = "Steel", Brand = "Rogue Fitness"},
                new Weight { WeightId = 5, WeightType = "Deadlift Bar", Pounds = 55, Material = "Steel", Brand = "Rogue Fitness"}
            );
        }
    }
}

 