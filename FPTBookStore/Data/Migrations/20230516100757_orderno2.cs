using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPTBookStore.Data.Migrations
{
    /// <inheritdoc />
    public partial class orderno2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_AspNetUsers_ApplicationUser",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_ApplicationUser",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ApplicationUser",
                table: "Order");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Order",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId",
                table: "Order",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_AspNetUsers_UserId",
                table: "Order",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_AspNetUsers_UserId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_UserId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Order");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUser",
                table: "Order",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ApplicationUser",
                table: "Order",
                column: "ApplicationUser");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_AspNetUsers_ApplicationUser",
                table: "Order",
                column: "ApplicationUser",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
