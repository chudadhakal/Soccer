using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Soccer.MVC.Migrations
{
    public partial class Initial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Player_ID",
                table: "Award_Season",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Player_ID",
                table: "Award_Season");
        }
    }
}
