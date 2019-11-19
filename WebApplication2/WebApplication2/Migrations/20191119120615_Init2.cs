using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class Init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "c639f2b2-4c5e-4e68-a395-65c62bbe33ca");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "ea5b843d-596f-43a0-9d6f-f65de83fe408");

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: "2eeb343f-f9ef-4d4c-9703-c13fe123e24a");

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: "86bbaa00-1ea9-4094-afbf-2dc4d1099b4c");

            migrationBuilder.AlterColumn<Guid>(
                name: "ToId",
                table: "Orders",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "FromId",
                table: "Orders",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Locations",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Drivers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("c22eb9c3-013c-4ff5-afe6-21abdc1b15d8"), "Аскар", "+77017778899" },
                    { new Guid("e6c42999-fe96-4828-b716-c9a317b257d2"), "Олег Скидан", "+77015554411" }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "Car", "CarNumber", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("efe05d5f-0b33-4d39-a063-27fc2e973d35"), "Range Rover Voque 3", "z001mmm", "Graf Aleksandr III", "+77013336655" },
                    { new Guid("c6c1f70b-2870-44aa-b3d5-4cbd938a2797"), "Maybach Original Reserve", "kz001", "Kasym Jomart", "+77010202022" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("c22eb9c3-013c-4ff5-afe6-21abdc1b15d8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("e6c42999-fe96-4828-b716-c9a317b257d2"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("c6c1f70b-2870-44aa-b3d5-4cbd938a2797"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("efe05d5f-0b33-4d39-a063-27fc2e973d35"));

            migrationBuilder.AlterColumn<string>(
                name: "ToId",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FromId",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Locations",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Drivers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Clients",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(Guid));

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
        }
    }
}
