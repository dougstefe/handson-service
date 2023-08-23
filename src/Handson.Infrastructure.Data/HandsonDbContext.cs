using Handson.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Handson.Infrastructure.Data
{
    public class HandsonDbContext : DbContext
    {
        public HandsonDbContext(DbContextOptions<HandsonDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            ArgumentNullException.ThrowIfNull(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(HandsonDbContext).Assembly);
        }

        public DbSet<Student> Students => Set<Student>();
        public DbSet<Address> Addresses => Set<Address>();
        public DbSet<Subscription> Subscriptions => Set<Subscription>();
        public DbSet<Payment> Payments => Set<Payment>();
        public DbSet<Lesson> Lessons => Set<Lesson>();
        public DbSet<Course> Courses => Set<Course>();

    }
}
