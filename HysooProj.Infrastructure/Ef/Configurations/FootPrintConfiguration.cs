using HyesooProj.Infrastructure.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HyesooProj.Infrastructure.Ef.Configurations
{
    public class FootPrintConfiguration : IEntityTypeConfiguration<FootPrint>
    {
        public void Configure(EntityTypeBuilder<FootPrint> builder)
        {
            builder.HasKey(o => o.Id);
            builder.OwnsOne(
                o => o.Daily,
                DailyFootPrint =>
                {
                    DailyFootPrint.Property(o => o.DateTime);
                    DailyFootPrint.Property(o => o.Name);
                });
        }
    }
}
