using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using VejledningBooking.Domain.Model;

namespace VejledningBooking.Database.ModelConfigurations
{
    public class Studentconfiguration : IEntityTypeConfiguration<Domain.Model.Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(a => a.Id);
        }
    }
}
