using Microsoft.EntityFrameworkCore;
using System.Reflection;
using VejledningBooking.Domain.Model;

namespace VejledningBooking.Database
{
    public class BookingContext : DbContext
    {
        public BookingContext(DbContextOptions<BookingContext> options) : base(options)
        {
        }

        public DbSet<BookingType> BookingType { get; set; }

        public DbSet<Domain.Model.Booking> Bookings { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //this will apply configs from separate classes which implemented IEntityTypeConfiguration<T>
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
