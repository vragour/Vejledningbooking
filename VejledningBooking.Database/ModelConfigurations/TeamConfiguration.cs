using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using VejledningBooking.Domain.Model;

namespace VejledningBooking.Database.ModelConfigurations
{
    public class TeamConfiguration : IEntityTypeConfiguration<Domain.Model.Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasKey(a => a.Id);
        }
    }
}
