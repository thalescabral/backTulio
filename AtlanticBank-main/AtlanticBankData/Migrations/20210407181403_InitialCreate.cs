using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AtlanticBankData.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CashMachines",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Balance = table.Column<long>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Two = table.Column<int>(nullable: false),
                    Five = table.Column<int>(nullable: false),
                    Ten = table.Column<int>(nullable: false),
                    Twenty = table.Column<int>(nullable: false),
                    Fifty = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashMachines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Saques",
                columns: table => new
                {
                    IdCashMachine = table.Column<Guid>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    Value = table.Column<decimal>(type: "decimal(4,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saques", x => x.IdCashMachine);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CashMachines");

            migrationBuilder.DropTable(
                name: "Saques");
        }
    }
}
