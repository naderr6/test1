using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aulfah.DAL.Migrations
{
    public partial class UpdatedProjectModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArtistID",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Product_ArtistID",
                table: "Product",
                column: "ArtistID");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Artist_ArtistID",
                table: "Product",
                column: "ArtistID",
                principalTable: "Artist",
                principalColumn: "ArtistID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Artist_ArtistID",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_ArtistID",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ArtistID",
                table: "Product");
        }
    }
}
