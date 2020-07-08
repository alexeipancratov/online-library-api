using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineLibrary.Data.Migrations
{
    public partial class ExtendedDomain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Books",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "RentPrice",
                table: "Books",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SalePrice",
                table: "Books",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "RentPrice",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "SalePrice",
                table: "Books");
        }
    }
}
