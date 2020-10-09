using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentDotNet2020.Server.Migrations
{
    public partial class TiempoDeCola : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "time",
                table: "Colas",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "time",
                table: "Colas");
        }
    }
}
