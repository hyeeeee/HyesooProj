﻿// <auto-generated />
using System;
using HyesooProj.Infrastructure.Ef;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HyesooProj.Infrastructure.Migrations
{
    [DbContext(typeof(HyesooProjDbContext))]
    partial class HyesooProjDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099");

            modelBuilder.Entity("HyesooProj.Infrastructure.Model.CoffeeTime", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FootPrintId");

                    b.Property<DateTime>("When");

                    b.Property<string>("With");

                    b.HasKey("Id");

                    b.HasIndex("FootPrintId");

                    b.ToTable("CoffeeTime");
                });

            modelBuilder.Entity("HyesooProj.Infrastructure.Model.FootPrint", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("FootPrints");
                });

            modelBuilder.Entity("HyesooProj.Infrastructure.Model.CoffeeTime", b =>
                {
                    b.HasOne("HyesooProj.Infrastructure.Model.FootPrint")
                        .WithMany("CoffeeTimes")
                        .HasForeignKey("FootPrintId");
                });

            modelBuilder.Entity("HyesooProj.Infrastructure.Model.FootPrint", b =>
                {
                    b.OwnsOne("HyesooProj.Infrastructure.Model.DailyFootPrint", "Daily", b1 =>
                        {
                            b1.Property<string>("FootPrintId");

                            b1.Property<DateTime>("DateTime");

                            b1.Property<string>("Name");

                            b1.ToTable("FootPrints");

                            b1.HasOne("HyesooProj.Infrastructure.Model.FootPrint")
                                .WithOne("Daily")
                                .HasForeignKey("HyesooProj.Infrastructure.Model.DailyFootPrint", "FootPrintId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
