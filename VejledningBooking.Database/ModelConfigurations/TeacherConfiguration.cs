using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using VejledningBooking.Domain.Model;

namespace VejledningBooking.Database.ModelConfigurations
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Domain.Model.Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasKey(a => a.Id);
        }
    }
}
