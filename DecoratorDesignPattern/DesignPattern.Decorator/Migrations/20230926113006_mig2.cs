using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesignPattern.Decorator.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notifiers",
                columns: table => new
                {
                    NotifierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotifierCreater = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotiferSubject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotifierType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotifierChannel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifiers", x => x.NotifierId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifiers");
        }
    }
}
