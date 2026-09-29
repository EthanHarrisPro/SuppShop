using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuppShop.Migrations
{
    /// <inheritdoc />
    public partial class AddCustomerFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "CustomerLog",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerLog_CustomerId",
                table: "CustomerLog",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerLog_Customers_CustomerId",
                table: "CustomerLog",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerLog_Customers_CustomerId",
                table: "CustomerLog");

            migrationBuilder.DropIndex(
                name: "IX_CustomerLog_CustomerId",
                table: "CustomerLog");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "CustomerLog");
        }
    }
}
