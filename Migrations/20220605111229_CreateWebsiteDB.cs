using Microsoft.EntityFrameworkCore.Migrations;

namespace HW_Simple_Crud_Cli_App_NadavArania.Migrations
{
    public partial class CreateWebsiteDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fields",
                columns: table => new
                {
                    FieldId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FieldName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FieldAge = table.Column<int>(type: "int", nullable: false),
                    FieldExperince = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fields", x => x.FieldId);
                });

            migrationBuilder.CreateTable(
                name: "Journalists",
                columns: table => new
                {
                    JournalistId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JournalistName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JournalistAge = table.Column<int>(type: "int", nullable: false),
                    JournalistExperince = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Journalists", x => x.JournalistId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fields");

            migrationBuilder.DropTable(
                name: "Journalists");
        }
    }
}
