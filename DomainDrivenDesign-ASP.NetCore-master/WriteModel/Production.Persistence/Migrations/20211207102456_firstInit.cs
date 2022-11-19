using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Production.Persistence.Migrations
{
    public partial class firstInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "WriteModel");

            migrationBuilder.CreateTable(
                name: "ProductionLine",
                schema: "WriteModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    CostCenter = table.Column<int>(type: "int", nullable: false),
                    ProductionLineTitle = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionLine", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductionLine",
                schema: "WriteModel");
        }
    }
}
