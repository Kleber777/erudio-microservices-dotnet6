using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class SeedProductDatatable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "describe", "image_url", "name", "price" },
                values: new object[] { 3L, "categoria 3", "Nome + o número", "Imagem para URL 3", "Name 3", 69.9m });

            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "describe", "image_url", "name", "price" },
                values: new object[] { 4L, "categoria 4", "Nome + o número", "Imagem para URL 4", "Name 4", 69.9m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);
        }
    }
}
