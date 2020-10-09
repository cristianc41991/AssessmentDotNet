using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentDotNet2020.Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cola = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Peoples",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peoples", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ColaPeoples",
                columns: table => new
                {
                    ColaId = table.Column<int>(nullable: false),
                    PeopleId = table.Column<int>(nullable: false),
                    status = table.Column<int>(nullable: false),
                    position = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColaPeoples", x => new { x.ColaId, x.PeopleId });
                    table.ForeignKey(
                        name: "FK_ColaPeoples_Colas_ColaId",
                        column: x => x.ColaId,
                        principalTable: "Colas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ColaPeoples_Peoples_PeopleId",
                        column: x => x.PeopleId,
                        principalTable: "Peoples",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ColaPeoples_PeopleId",
                table: "ColaPeoples",
                column: "PeopleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ColaPeoples");

            migrationBuilder.DropTable(
                name: "Colas");

            migrationBuilder.DropTable(
                name: "Peoples");
        }
    }
}
