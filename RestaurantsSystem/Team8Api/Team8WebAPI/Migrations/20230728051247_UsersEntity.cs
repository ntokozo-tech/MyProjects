using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Team8WebAPI.Migrations
{
    public partial class UsersEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    U_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    U_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    U_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    U_CellNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    U_username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    U_Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    U_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    R_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.U_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
