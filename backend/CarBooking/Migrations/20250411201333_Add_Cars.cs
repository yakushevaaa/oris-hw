using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarBooking.Migrations
{
    /// <inheritdoc />
    public partial class Add_Cars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Category", "Img", "Name", "Price", "Spaces", "Transmission" },
                values: new object[,]
                {
                    { 1, 0, "https://static.lada.ru/images/v6/cars/configurator/granta/sedan.webp", "LADA Granta", 99m, 3, 0 },
                    { 2, 2, "https://static.lada.ru/images/v6/cars/configurator/granta/liftback.webp", "LADA Granta", 100m, 2, 0 },
                    { 3, 3, "https://static.lada.ru/images/v6/cars/configurator/granta/cross.webp", "LADA Granta", 80m, 5, 1 },
                    { 4, 0, "https://static.lada.ru/images/v6/cars/configurator/vesta_new/sedan.webp", "LADA Vesta", 50m, 4, 0 },
                    { 5, 1, "https://static.lada.ru/images/v6/cars/configurator/vesta_new/cross.webp", "LADA Vesta", 120m, 4, 1 },
                    { 6, 4, "https://static.lada.ru/images/v6/cars/configurator/vesta_new/sw.webp", "LADA Vesta", 100m, 5, 1 },
                    { 7, 5, "https://static.lada.ru/images/v6/cars/configurator/vesta_new/sedan.webp", "LADA Largus", 40m, 5, 0 },
                    { 8, 1, "https://static.lada.ru/images/v6/cars/configurator/vesta_new/cross.webp", "LADA Largus", 40m, 4, 1 },
                    { 9, 3, "https://static.lada.ru/images/v6/cars/configurator/vesta_new/sportline.webp", "LADA Vesta", 100m, 5, 1 },
                    { 10, 3, "https://static.lada.ru/images/v6/cars/configurator/granta/sportline.webp", "LADA Granta", 120m, 5, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
