using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Commodity_Request_Form.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CHA",
                columns: table => new
                {
                    CHA_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    L_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHA", x => x.CHA_ID);
                });

            migrationBuilder.CreateTable(
                name: "CHW",
                columns: table => new
                {
                    CHW_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    L_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHA_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHW", x => x.CHW_ID);
                    table.ForeignKey(
                        name: "FK_CHW_CHA_CHA_ID",
                        column: x => x.CHA_ID,
                        principalTable: "CHA",
                        principalColumn: "CHA_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Commodity",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CHW_ID = table.Column<int>(type: "int", nullable: false),
                    CHA_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commodity", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Commodity_CHA_CHA_ID",
                        column: x => x.CHA_ID,
                        principalTable: "CHA",
                        principalColumn: "CHA_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Commodity_CHW_CHW_ID",
                        column: x => x.CHW_ID,
                        principalTable: "CHW",
                        principalColumn: "CHW_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CHW_CHA_ID",
                table: "CHW",
                column: "CHA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Commodity_CHA_ID",
                table: "Commodity",
                column: "CHA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Commodity_CHW_ID",
                table: "Commodity",
                column: "CHW_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commodity");

            migrationBuilder.DropTable(
                name: "CHW");

            migrationBuilder.DropTable(
                name: "CHA");
        }
    }
}
