using CarBooking.Models;
using Microsoft.EntityFrameworkCore;

namespace CarBooking.Persistence
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CarsConfiguration());

            modelBuilder.ApplyConfiguration(new CommentsConfiguration());

        }
    }
}
