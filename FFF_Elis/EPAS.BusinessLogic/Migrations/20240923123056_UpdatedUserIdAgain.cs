using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EPAS.BusinessLogic.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedUserIdAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OperationResponses_AspNetUsers_UserId1",
                table: "OperationResponses");

            migrationBuilder.DropIndex(
                name: "IX_OperationResponses_UserId1",
                table: "OperationResponses");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "OperationResponses");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "OperationResponses",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateIndex(
                name: "IX_OperationResponses_UserId",
                table: "OperationResponses",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_OperationResponses_AspNetUsers_UserId",
                table: "OperationResponses",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OperationResponses_AspNetUsers_UserId",
                table: "OperationResponses");

            migrationBuilder.DropIndex(
                name: "IX_OperationResponses_UserId",
                table: "OperationResponses");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "OperationResponses",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "OperationResponses",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OperationResponses_UserId1",
                table: "OperationResponses",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_OperationResponses_AspNetUsers_UserId1",
                table: "OperationResponses",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
