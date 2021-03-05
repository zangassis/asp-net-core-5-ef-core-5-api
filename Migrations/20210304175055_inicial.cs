using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegisterProductsApi.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(80) CHARACTER SET utf8mb4", maxLength: 80, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Inventory = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Inventory", "Name", "Price" },
                values: new object[] { 1, 10, "ExampleOne", 1.01m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Inventory", "Name", "Price" },
                values: new object[] { 2, 20, "ExampleTwo", 2.02m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Inventory", "Name", "Price" },
                values: new object[] { 3, 30, "ExampleTree", 3.03m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
