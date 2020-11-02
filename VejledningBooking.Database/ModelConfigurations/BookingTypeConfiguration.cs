using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using VejledningBooking.Domain.Model;

namespace VejledningBooking.Database.ModelConfigurations
{
    public class BookingTypeConfiguration: IEntityTypeConfiguration<Domain.Model.BookingType>
    {
        public void Configure(EntityTypeBuilder<BookingType> builder)
        {
            builder.HasKey(a => a.Id);
        }
    }
}
