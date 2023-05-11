using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eshop.Migrations.UserProduct
{
    /// <inheritdoc />
    public partial class productmigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    property1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    property2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    property3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    property4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProducts", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserProducts");
        }
    }
}
