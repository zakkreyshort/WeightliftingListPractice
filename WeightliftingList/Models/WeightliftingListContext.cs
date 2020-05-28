using Microsoft.EntityFrameworkCore;

namespace WeightliftingList.Models
{
    public class WeightliftingListContext : DbContext
    {
        public WeightliftingListContext(DbContextOptions<WeightliftingListContext> options) : base(options)
        {
        }
        public DbSet<Weight> Weights { get; set; }
    }
}