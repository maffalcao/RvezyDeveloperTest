using Domain.Entities;
using Infra.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Infra.Context
{
    public class MyContext : DbContext
    {
        public DbSet<CalendarEntity> Calendars { get; set; }
        public DbSet<ListingEntity> Listings { get; set; }
        public DbSet<ReviewEntity> Reviews { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CalendarEntity>(new CalendarMapping().Configure);
            modelBuilder.Entity<ListingEntity>(new ListingMapping().Configure);
            modelBuilder.Entity<ReviewEntity>(new ReviewMapping().Configure);
        }
    }
}