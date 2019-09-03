using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HyesooProj.Infrastructure.Migrations
{
    public partial class addcoffeetime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CoffeeTime",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    With = table.Column<string>(nullable: true),
                    When = table.Column<DateTime>(nullable: false),
                    FootPrintId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoffeeTime", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoffeeTime_FootPrints_FootPrintId",
                        column: x => x.FootPrintId,
                        principalTable: "FootPrints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CoffeeTime_FootPrintId",
                table: "CoffeeTime",
                column: "FootPrintId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoffeeTime");
        }
    }
}
