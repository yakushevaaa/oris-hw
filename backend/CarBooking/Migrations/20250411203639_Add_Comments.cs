using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarBooking.Migrations
{
    /// <inheritdoc />
    public partial class Add_Comments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Position = table.Column<string>(type: "text", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    CarId = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Img = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CarId", "Date", "Img", "Name", "Position", "Text" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 4, 20, 0, 0, 0, 0, DateTimeKind.Utc), "/images/tagir.jpg", "Tagir Akhmetshin", "Senior Backend Developer", "Отличная машина, лучше всех. Мне очень нравится" },
                    { 2, 1, new DateTime(2025, 4, 20, 0, 0, 0, 0, DateTimeKind.Utc), "/images/vlada.jpg", "Vlada Yakusheva", "Senior Frontend Developer", "Супер машина, все удочки помещаются" },
                    { 3, 2, new DateTime(2025, 4, 20, 0, 0, 0, 0, DateTimeKind.Utc), "https://camo.githubusercontent.com/619e60801937aeb64755546251df3a4ffe1a786a38e91ee33d2c81eccca9685e/68747470733a2f2f617661746172732e6d64732e79616e6465782e6e65742f693f69643d34316661666336623632636363313037623761666233396435376266633564665f6c2d373130363839392d696d616765732d7468756d6273266e3d3133", "Ivan Ivanov", "Developer", "Really good car" },
                    { 4, 3, new DateTime(2025, 4, 20, 0, 0, 0, 0, DateTimeKind.Utc), "https://camo.githubusercontent.com/619e60801937aeb64755546251df3a4ffe1a786a38e91ee33d2c81eccca9685e/68747470733a2f2f617661746172732e6d64732e79616e6465782e6e65742f693f69643d34316661666336623632636363313037623761666233396435376266633564665f6c2d373130363839392d696d616765732d7468756d6273266e3d3133", "Ivan Ivanov", "Developer", "Really good car" },
                    { 5, 4, new DateTime(2025, 4, 20, 0, 0, 0, 0, DateTimeKind.Utc), "https://camo.githubusercontent.com/619e60801937aeb64755546251df3a4ffe1a786a38e91ee33d2c81eccca9685e/68747470733a2f2f617661746172732e6d64732e79616e6465782e6e65742f693f69643d34316661666336623632636363313037623761666233396435376266633564665f6c2d373130363839392d696d616765732d7468756d6273266e3d3133", "Ivan Ivanov", "Developer", "Really good car" },
                    { 6, 5, new DateTime(2025, 4, 20, 0, 0, 0, 0, DateTimeKind.Utc), "https://camo.githubusercontent.com/619e60801937aeb64755546251df3a4ffe1a786a38e91ee33d2c81eccca9685e/68747470733a2f2f617661746172732e6d64732e79616e6465782e6e65742f693f69643d34316661666336623632636363313037623761666233396435376266633564665f6c2d373130363839392d696d616765732d7468756d6273266e3d3133", "Ivan Ivanov", "Developer", "Really good car" },
                    { 7, 6, new DateTime(2025, 4, 20, 0, 0, 0, 0, DateTimeKind.Utc), "https://camo.githubusercontent.com/619e60801937aeb64755546251df3a4ffe1a786a38e91ee33d2c81eccca9685e/68747470733a2f2f617661746172732e6d64732e79616e6465782e6e65742f693f69643d34316661666336623632636363313037623761666233396435376266633564665f6c2d373130363839392d696d616765732d7468756d6273266e3d3133", "Ivan Ivanov", "Developer", "Really good car" },
                    { 8, 7, new DateTime(2025, 4, 20, 0, 0, 0, 0, DateTimeKind.Utc), "https://camo.githubusercontent.com/619e60801937aeb64755546251df3a4ffe1a786a38e91ee33d2c81eccca9685e/68747470733a2f2f617661746172732e6d64732e79616e6465782e6e65742f693f69643d34316661666336623632636363313037623761666233396435376266633564665f6c2d373130363839392d696d616765732d7468756d6273266e3d3133", "Ivan Ivanov", "Developer", "Really good car" },
                    { 9, 8, new DateTime(2025, 4, 20, 0, 0, 0, 0, DateTimeKind.Utc), "https://camo.githubusercontent.com/619e60801937aeb64755546251df3a4ffe1a786a38e91ee33d2c81eccca9685e/68747470733a2f2f617661746172732e6d64732e79616e6465782e6e65742f693f69643d34316661666336623632636363313037623761666233396435376266633564665f6c2d373130363839392d696d616765732d7468756d6273266e3d3133", "Ivan Ivanov", "Developer", "Really good car" },
                    { 10, 9, new DateTime(2025, 4, 20, 0, 0, 0, 0, DateTimeKind.Utc), "https://camo.githubusercontent.com/619e60801937aeb64755546251df3a4ffe1a786a38e91ee33d2c81eccca9685e/68747470733a2f2f617661746172732e6d64732e79616e6465782e6e65742f693f69643d34316661666336623632636363313037623761666233396435376266633564665f6c2d373130363839392d696d616765732d7468756d6273266e3d3133", "Ivan Ivanov", "Developer", "Really good car" },
                    { 11, 10, new DateTime(2025, 4, 20, 0, 0, 0, 0, DateTimeKind.Utc), "https://camo.githubusercontent.com/619e60801937aeb64755546251df3a4ffe1a786a38e91ee33d2c81eccca9685e/68747470733a2f2f617661746172732e6d64732e79616e6465782e6e65742f693f69643d34316661666336623632636363313037623761666233396435376266633564665f6c2d373130363839392d696d616765732d7468756d6273266e3d3133", "Ivan Ivanov", "Developer", "Really good car" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");
        }
    }
}
