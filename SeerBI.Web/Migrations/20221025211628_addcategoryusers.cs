using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeerBI.Web.Migrations
{
    public partial class addcategoryusers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "category",
                table: "AspNetUsers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "category",
                table: "AspNetUsers");
        }
    }
}
