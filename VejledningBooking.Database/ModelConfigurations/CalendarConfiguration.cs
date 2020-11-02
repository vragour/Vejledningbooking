using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using VejledningBooking.Domain.Model;

namespace VejledningBooking.Database.ModelConfigurations
{
    class CalendarConfiguration : IEntityTypeConfiguration<Domain.Model.Calender>
    {
        public void Configure(EntityTypeBuilder<Calender> builder)
        {
            builder.HasKey(a => a.Id);
        }
    }
}
