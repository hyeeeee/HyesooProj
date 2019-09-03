using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyesooProj.Infrastructure.Migrations
{
    public partial class adddaily : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DailyId",
                table: "FootPrints",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DailyFootPrint",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyFootPrint", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FootPrints_DailyId",
                table: "FootPrints",
                column: "DailyId");

            migrationBuilder.AddForeignKey(
                name: "FK_FootPrints_DailyFootPrint_DailyId",
                table: "FootPrints",
                column: "DailyId",
                principalTable: "DailyFootPrint",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FootPrints_DailyFootPrint_DailyId",
                table: "FootPrints");

            migrationBuilder.DropTable(
                name: "DailyFootPrint");

            migrationBuilder.DropIndex(
                name: "IX_FootPrints_DailyId",
                table: "FootPrints");

            migrationBuilder.DropColumn(
                name: "DailyId",
                table: "FootPrints");
        }
    }
}
