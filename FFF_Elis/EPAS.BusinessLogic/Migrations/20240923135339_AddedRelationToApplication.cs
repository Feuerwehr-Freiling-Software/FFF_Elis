using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EPAS.BusinessLogic.Migrations
{
    /// <inheritdoc />
    public partial class AddedRelationToApplication : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Firebrigades_FirebrigadeId",
                table: "Applications");

            migrationBuilder.AlterColumn<int>(
                name: "FirebrigadeId",
                table: "Applications",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Firebrigades_FirebrigadeId",
                table: "Applications",
                column: "FirebrigadeId",
                principalTable: "Firebrigades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Firebrigades_FirebrigadeId",
                table: "Applications");

            migrationBuilder.AlterColumn<int>(
                name: "FirebrigadeId",
                table: "Applications",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Firebrigades_FirebrigadeId",
                table: "Applications",
                column: "FirebrigadeId",
                principalTable: "Firebrigades",
                principalColumn: "Id");
        }
    }
}
