using HyesooProj.Infrastructure.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HyesooProj.Infrastructure.Ef.Configurations
{
    public class DailyFootPrintConfiguration : IEntityTypeConfiguration<DailyFootPrint>
    {
        public void Configure(EntityTypeBuilder<DailyFootPrint> builder)
        {
            builder.HasKey(o => o.Name);
        }
    }
}
