using Microsoft.EntityFrameworkCore.Migrations;

namespace CovidCare.Migrations.Quarantine
{
    public partial class Quarantine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quarantines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Centres = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Beds = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Aadhar = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(12)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quarantines", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quarantines");
        }
    }
}
