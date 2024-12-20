using Microsoft.EntityFrameworkCore;

namespace BirthdayCalendar.Models
{
    public class BirthdayCalendarDbContext : DbContext
    {
        public BirthdayCalendarDbContext(DbContextOptions<BirthdayCalendarDbContext> options)
            : base(options) 
        {
            
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define the one-to-one relationship
            modelBuilder.Entity<User>()
                .HasOne(u => u.BirthdayEvent) // One User has one Birthday Event
                .WithOne(e => e.User)        // One Event is linked to one User
                .HasForeignKey<User>(u => u.BirthdayEventId) // FK in User table
                .OnDelete(DeleteBehavior.Restrict); // Optional: Restrict cascading deletes

            base.OnModelCreating(modelBuilder);
        }
    }
}
