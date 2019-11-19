using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Car = table.Column<string>(nullable: true),
                    CarNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    FromId = table.Column<string>(nullable: true),
                    ToId = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    CreationOrder = table.Column<DateTime>(nullable: false),
                    ClientId = table.Column<Guid>(nullable: false),
                    DriverId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Locations_FromId",
                        column: x => x.FromId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Locations_ToId",
                        column: x => x.ToId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { "c639f2b2-4c5e-4e68-a395-65c62bbe33ca", "Аскар", "+77017778899" },
                    { "ea5b843d-596f-43a0-9d6f-f65de83fe408", "Олег Скидан", "+77015554411" }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "Car", "CarNumber", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { "86bbaa00-1ea9-4094-afbf-2dc4d1099b4c", "Range Rover Voque 3", "z001mmm", "Graf Aleksandr III", "+77013336655" },
                    { "2eeb343f-f9ef-4d4c-9703-c13fe123e24a", "Maybach Original Reserve", "kz001", "Kasym Jomart", "+77010202022" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_FromId",
                table: "Orders",
                column: "FromId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ToId",
                table: "Orders",
                column: "ToId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
