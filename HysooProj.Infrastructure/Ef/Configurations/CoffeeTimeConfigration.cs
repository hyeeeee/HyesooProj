using HyesooProj.Infrastructure.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HyesooProj.Infrastructure.Ef.Configurations
{
    public class CoffeeTimeConfigration : IEntityTypeConfiguration<CoffeeTime>
    {
        public void Configure(EntityTypeBuilder<CoffeeTime> builder)
        {
            builder.HasKey(o => o.Id);

        }
    }
}
