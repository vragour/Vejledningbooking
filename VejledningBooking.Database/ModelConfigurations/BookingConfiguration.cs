using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VejledningBooking.Domain.Model;
namespace VejledningBooking.Database.ModelConfigurations
{
    public class BookingConfiguration : IEntityTypeConfiguration<Domain.Model.Booking>
    {

        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.HasKey(a => a.Id);
        }
    }
}
