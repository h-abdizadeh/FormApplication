using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taxi.Migrations
{
    public partial class setting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FaceImg",
                table: "Drivers",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FaceImg",
                table: "Drivers");
        }
    }
}
