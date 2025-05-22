using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Commodity_Request_Form.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CHA",
                columns: new[] { "CHA_ID", "F_Name", "L_Name" },
                values: new object[,]
                {
                    { 1, "Alice", "Kamau" },
                    { 2, "John", "Otieno" },
                    { 3, "Mary", "Wangari" },
                    { 4, "David", "Mwangi" }
                });

            migrationBuilder.InsertData(
                table: "CHW",
                columns: new[] { "CHW_ID", "CHA_ID", "F_Name", "L_Name" },
                values: new object[,]
                {
                    { 1, 1, "Grace", "Njeri" },
                    { 2, 2, "Peter", "Otieno" },
                    { 3, 1, "Esther", "Wangari" },
                    { 4, 3, "James", "Mwangi" },
                    { 5, 4, "Faith", "Nyaoga" },
                    { 6, 1, "Samuel", "Kamau" },
                    { 7, 1, "Rebecca", "Nyambura" },
                    { 8, 1, "David", "Owino" },
                    { 9, 2, "Alice", "Kilonzo" },
                    { 10, 2, "Michael", "Otieno" },
                    { 11, 3, "Esther", "Ochieng" },
                    { 12, 3, "Paul", "Ndegwa" },
                    { 13, 4, "Joyce", "Akinyi" },
                    { 14, 4, "Benjamin", "Mwangi" }
                });

            migrationBuilder.InsertData(
                table: "Commodity",
                columns: new[] { "ID", "CHA_ID", "CHW_ID", "DateRequested", "Name", "Quantity", "Status" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2025, 5, 12, 19, 42, 0, 829, DateTimeKind.Local).AddTicks(6833), "Malaria Drugs", 50, 1 },
                    { 2, 2, 2, new DateTime(2025, 5, 14, 19, 42, 0, 829, DateTimeKind.Local).AddTicks(7715), "Family Planning Items", 30, 1 },
                    { 3, 1, 3, new DateTime(2025, 5, 17, 19, 42, 0, 829, DateTimeKind.Local).AddTicks(7721), "Zinc Tablets", 40, 2 },
                    { 4, 3, 4, new DateTime(2025, 5, 19, 19, 42, 0, 829, DateTimeKind.Local).AddTicks(7722), "Malaria Drugs", 60, 0 },
                    { 5, 4, 5, new DateTime(2025, 5, 21, 19, 42, 0, 829, DateTimeKind.Local).AddTicks(7724), "Family Planning Items", 25, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CHW",
                keyColumn: "CHW_ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CHW",
                keyColumn: "CHW_ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CHW",
                keyColumn: "CHW_ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CHW",
                keyColumn: "CHW_ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CHW",
                keyColumn: "CHW_ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CHW",
                keyColumn: "CHW_ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CHW",
                keyColumn: "CHW_ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CHW",
                keyColumn: "CHW_ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CHW",
                keyColumn: "CHW_ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Commodity",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Commodity",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Commodity",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Commodity",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Commodity",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CHW",
                keyColumn: "CHW_ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CHW",
                keyColumn: "CHW_ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CHW",
                keyColumn: "CHW_ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CHW",
                keyColumn: "CHW_ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CHW",
                keyColumn: "CHW_ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CHA",
                keyColumn: "CHA_ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CHA",
                keyColumn: "CHA_ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CHA",
                keyColumn: "CHA_ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CHA",
                keyColumn: "CHA_ID",
                keyValue: 4);
        }
    }
}
