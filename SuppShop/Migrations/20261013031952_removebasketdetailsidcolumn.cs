using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuppShop.Migrations
{
    /// <inheritdoc />
    public partial class removebasketdetailsidcolumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BasketDetailsId",
                table: "Basket");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BasketDetailsId",
                table: "Basket",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
