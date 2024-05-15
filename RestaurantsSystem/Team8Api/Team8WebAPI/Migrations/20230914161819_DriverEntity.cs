using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Team8WebAPI.Migrations
{
    public partial class DriverEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "drivers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DriverPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DriverEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DriverPictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DriverRating = table.Column<int>(type: "int", nullable: false),
                    DriverCompletedTrips = table.Column<int>(type: "int", nullable: false),
                    DriverAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DriverLanguages = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drivers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "drivers");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "orders");
        }
    }
}
