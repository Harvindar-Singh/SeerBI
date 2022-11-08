using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeerBI.Web.Migrations
{
    public partial class addingField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "profession",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "profession",
                table: "AspNetUsers");
        }
    }
}
