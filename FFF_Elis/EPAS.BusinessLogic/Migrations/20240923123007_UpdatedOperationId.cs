using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EPAS.BusinessLogic.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedOperationId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OperationResponses_Operations_OperationId1",
                table: "OperationResponses");

            migrationBuilder.DropIndex(
                name: "IX_OperationResponses_OperationId1",
                table: "OperationResponses");

            migrationBuilder.DropColumn(
                name: "OperationId1",
                table: "OperationResponses");

            migrationBuilder.AlterColumn<string>(
                name: "OperationId",
                table: "OperationResponses",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateIndex(
                name: "IX_OperationResponses_OperationId",
                table: "OperationResponses",
                column: "OperationId");

            migrationBuilder.AddForeignKey(
                name: "FK_OperationResponses_Operations_OperationId",
                table: "OperationResponses",
                column: "OperationId",
                principalTable: "Operations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OperationResponses_Operations_OperationId",
                table: "OperationResponses");

            migrationBuilder.DropIndex(
                name: "IX_OperationResponses_OperationId",
                table: "OperationResponses");

            migrationBuilder.AlterColumn<int>(
                name: "OperationId",
                table: "OperationResponses",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "OperationId1",
                table: "OperationResponses",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OperationResponses_OperationId1",
                table: "OperationResponses",
                column: "OperationId1");

            migrationBuilder.AddForeignKey(
                name: "FK_OperationResponses_Operations_OperationId1",
                table: "OperationResponses",
                column: "OperationId1",
                principalTable: "Operations",
                principalColumn: "Id");
        }
    }
}
