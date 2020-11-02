using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using VejledningBooking.Domain.Model;

namespace VejledningBooking.Database.ModelConfigurations
{
    public class TimeslotConfiguration : IEntityTypeConfiguration<Domain.Model.Timeslot>
    {
        public void Configure(EntityTypeBuilder<Timeslot> builder)
        {
            builder.HasKey(a => a.Id);
        }
    }
}
