using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Commodity_Request_Form.Migrations
{
    /// <inheritdoc />
    public partial class FixedSeedDates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Commodity",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateRequested",
                value: new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Commodity",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateRequested",
                value: new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Commodity",
                keyColumn: "ID",
                keyValue: 3,
                column: "DateRequested",
                value: new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Commodity",
                keyColumn: "ID",
                keyValue: 4,
                column: "DateRequested",
                value: new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Commodity",
                keyColumn: "ID",
                keyValue: 5,
                column: "DateRequested",
                value: new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Commodity",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateRequested",
                value: new DateTime(2025, 5, 12, 19, 42, 0, 829, DateTimeKind.Local).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "Commodity",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateRequested",
                value: new DateTime(2025, 5, 14, 19, 42, 0, 829, DateTimeKind.Local).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "Commodity",
                keyColumn: "ID",
                keyValue: 3,
                column: "DateRequested",
                value: new DateTime(2025, 5, 17, 19, 42, 0, 829, DateTimeKind.Local).AddTicks(7721));

            migrationBuilder.UpdateData(
                table: "Commodity",
                keyColumn: "ID",
                keyValue: 4,
                column: "DateRequested",
                value: new DateTime(2025, 5, 19, 19, 42, 0, 829, DateTimeKind.Local).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "Commodity",
                keyColumn: "ID",
                keyValue: 5,
                column: "DateRequested",
                value: new DateTime(2025, 5, 21, 19, 42, 0, 829, DateTimeKind.Local).AddTicks(7724));
        }
    }
}
