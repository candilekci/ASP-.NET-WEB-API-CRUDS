using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelFinder.DataAccess.Migrations
{
    public partial class last : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Hotels_OtelId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_OtelId",
                table: "Comments");

            migrationBuilder.AlterColumn<int>(
                name: "OtelId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "OtelId",
                table: "Comments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_OtelId",
                table: "Comments",
                column: "OtelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Hotels_OtelId",
                table: "Comments",
                column: "OtelId",
                principalTable: "Hotels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
