using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EPAS.BusinessLogic.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Firebrigades_FirebrigadeId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Operations_Firebrigades_FirebrigadeId",
                table: "Operations");

            migrationBuilder.DropIndex(
                name: "IX_Operations_FirebrigadeId",
                table: "Operations");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_FirebrigadeId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirebrigadeId",
                table: "Operations");

            migrationBuilder.DropColumn(
                name: "FirebrigadeId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<DateTime>(
                name: "WatchOut",
                table: "Operations",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "ApplicationUserFirebrigade",
                columns: table => new
                {
                    FirebrigadesId = table.Column<int>(type: "INTEGER", nullable: false),
                    UsersId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserFirebrigade", x => new { x.FirebrigadesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserFirebrigade_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserFirebrigade_Firebrigades_FirebrigadesId",
                        column: x => x.FirebrigadesId,
                        principalTable: "Firebrigades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FirebrigadeOperation",
                columns: table => new
                {
                    FirebrigadesId = table.Column<int>(type: "INTEGER", nullable: false),
                    OperationsId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirebrigadeOperation", x => new { x.FirebrigadesId, x.OperationsId });
                    table.ForeignKey(
                        name: "FK_FirebrigadeOperation_Firebrigades_FirebrigadesId",
                        column: x => x.FirebrigadesId,
                        principalTable: "Firebrigades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FirebrigadeOperation_Operations_OperationsId",
                        column: x => x.OperationsId,
                        principalTable: "Operations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserFirebrigade_UsersId",
                table: "ApplicationUserFirebrigade",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_FirebrigadeOperation_OperationsId",
                table: "FirebrigadeOperation",
                column: "OperationsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserFirebrigade");

            migrationBuilder.DropTable(
                name: "FirebrigadeOperation");

            migrationBuilder.DropColumn(
                name: "WatchOut",
                table: "Operations");

            migrationBuilder.AddColumn<int>(
                name: "FirebrigadeId",
                table: "Operations",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FirebrigadeId",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Operations_FirebrigadeId",
                table: "Operations",
                column: "FirebrigadeId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_FirebrigadeId",
                table: "AspNetUsers",
                column: "FirebrigadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Firebrigades_FirebrigadeId",
                table: "AspNetUsers",
                column: "FirebrigadeId",
                principalTable: "Firebrigades",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Operations_Firebrigades_FirebrigadeId",
                table: "Operations",
                column: "FirebrigadeId",
                principalTable: "Firebrigades",
                principalColumn: "Id");
        }
    }
}
