using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aulfah.DAL.Migrations
{
    public partial class CarIdNotNullCustomerClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Customer_CartId",
                table: "Customer");

            migrationBuilder.AddColumn<string>(
                name: "Quantity",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customer_CartId",
                table: "Customer",
                column: "CartId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Customer_CartId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Product");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_CartId",
                table: "Customer",
                column: "CartId");
        }
    }
}
