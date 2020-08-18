using Microsoft.EntityFrameworkCore.Migrations;

namespace ExplorationApi.Solution.Migrations
{
    public partial class SeedMoreData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "PlaceId", "Country", "Description", "Name", "Rating", "UserName" },
                values: new object[,]
                {
                    { 8, "Mexico", "A warm sunny town with lots of good food carts and food fresh from the ocean.", "Puerta Vallarta", 5, "Brittany" },
                    { 32, "Mexico", "There was a hurricane! Was there for a wedding that had to be postponed.", "Puerta Vallarta", 1, "Kate" },
                    { 33, "France", "A beautiful little town outside of Gorges du Verdon. Great views and restaurants.", "La Palud sur Verdon", 5, "Kate" },
                    { 34, "Japan", "Town that has a famous fireworks show every summer, cute local shops and traditional Ryokan", "Matsue", 5, "Brittany" },
                    { 35, "Idk hawaii?", "Came expecting mystical underwater city, got some theme park, refund was not approved.", "Atlantis", 1, "Cody" },
                    { 36, "Japan", "Town that has a famous fireworks show every summer, cute local shops and traditional Ryokan", "Matsue", 5, "Brittany" },
                    { 37, "Idk hawaii?", "Came expecting mystical underwater city, got some theme park, refund was not approved.", "Atlantis", 1, "Cody" },
                    { 38, "Mexico", "A warm sunny town with lots of good food carts and food fresh from the ocean.", "Puerta Vallarta", 5, "Brittany" },
                    { 39, "USA", "A little town on the Oregon coast with beautiful views of the ocean and one brewery.", "Yachats", 4, "Brittany" },
                    { 31, "USA", "Not that scenic and way too crowded to enjoy, unless you have a boat or some other watercraft.", "Timothy Lake", 2, "Kate" },
                    { 40, "USA", "Not that scenic and way too crowded to enjoy, unless you have a boat or some other watercraft.", "Timothy Lake", 2, "Kate" },
                    { 42, "France", "A beautiful little town outside of Gorges du Verdon. Great views and restaurants.", "La Palud sur Verdon", 5, "Kate" },
                    { 43, "Japan", "Town that has a famous fireworks show every summer, cute local shops and traditional Ryokan", "Matsue", 5, "Brittany" },
                    { 44, "Idk hawaii?", "Came expecting mystical underwater city, got some theme park, refund was not approved.", "Atlantis", 1, "Cody" },
                    { 45, "Mexico", "A warm sunny town with lots of good food carts and food fresh from the ocean.", "Puerta Vallarta", 5, "Brittany" },
                    { 46, "USA", "A little town on the Oregon coast with beautiful views of the ocean and one brewery.", "Yachats", 4, "Brittany" },
                    { 47, "USA", "Not that scenic and way too crowded to enjoy, unless you have a boat or some other watercraft.", "Timothy Lake", 2, "Kate" },
                    { 48, "Mexico", "There was a hurricane! Was there for a wedding that had to be postponed.", "Puerta Vallarta", 1, "Kate" },
                    { 49, "France", "A beautiful little town outside of Gorges du Verdon. Great views and restaurants.", "La Palud sur Verdon", 5, "Kate" },
                    { 41, "Mexico", "There was a hurricane! Was there for a wedding that had to be postponed.", "Puerta Vallarta", 1, "Kate" },
                    { 30, "USA", "A little town on the Oregon coast with beautiful views of the ocean and one brewery.", "Yachats", 4, "Brittany" },
                    { 29, "Mexico", "A warm sunny town with lots of good food carts and food fresh from the ocean.", "Puerta Vallarta", 5, "Brittany" },
                    { 28, "Idk hawaii?", "Came expecting mystical underwater city, got some theme park, refund was not approved.", "Atlantis", 1, "Cody" },
                    { 9, "USA", "A little town on the Oregon coast with beautiful views of the ocean and one brewery.", "Yachats", 4, "Brittany" },
                    { 10, "USA", "Not that scenic and way too crowded to enjoy, unless you have a boat or some other watercraft.", "Timothy Lake", 2, "Kate" },
                    { 11, "Mexico", "There was a hurricane! Was there for a wedding that had to be postponed.", "Puerta Vallarta", 1, "Kate" },
                    { 12, "France", "A beautiful little town outside of Gorges du Verdon. Great views and restaurants.", "La Palud sur Verdon", 5, "Kate" },
                    { 13, "Japan", "Town that has a famous fireworks show every summer, cute local shops and traditional Ryokan", "Matsue", 5, "Brittany" },
                    { 14, "Idk hawaii?", "Came expecting mystical underwater city, got some theme park, refund was not approved.", "Atlantis", 1, "Cody" },
                    { 15, "Mexico", "A warm sunny town with lots of good food carts and food fresh from the ocean.", "Puerta Vallarta", 5, "Brittany" },
                    { 16, "USA", "A little town on the Oregon coast with beautiful views of the ocean and one brewery.", "Yachats", 4, "Brittany" },
                    { 17, "USA", "Not that scenic and way too crowded to enjoy, unless you have a boat or some other watercraft.", "Timothy Lake", 2, "Kate" },
                    { 18, "Mexico", "There was a hurricane! Was there for a wedding that had to be postponed.", "Puerta Vallarta", 1, "Kate" },
                    { 19, "France", "A beautiful little town outside of Gorges du Verdon. Great views and restaurants.", "La Palud sur Verdon", 5, "Kate" },
                    { 20, "Japan", "Town that has a famous fireworks show every summer, cute local shops and traditional Ryokan", "Matsue", 5, "Brittany" },
                    { 21, "Idk hawaii?", "Came expecting mystical underwater city, got some theme park, refund was not approved.", "Atlantis", 1, "Cody" },
                    { 22, "Mexico", "A warm sunny town with lots of good food carts and food fresh from the ocean.", "Puerta Vallarta", 5, "Brittany" },
                    { 23, "USA", "A little town on the Oregon coast with beautiful views of the ocean and one brewery.", "Yachats", 4, "Brittany" },
                    { 24, "USA", "Not that scenic and way too crowded to enjoy, unless you have a boat or some other watercraft.", "Timothy Lake", 2, "Kate" },
                    { 25, "Mexico", "There was a hurricane! Was there for a wedding that had to be postponed.", "Puerta Vallarta", 1, "Kate" },
                    { 26, "France", "A beautiful little town outside of Gorges du Verdon. Great views and restaurants.", "La Palud sur Verdon", 5, "Kate" },
                    { 27, "Japan", "Town that has a famous fireworks show every summer, cute local shops and traditional Ryokan", "Matsue", 5, "Brittany" },
                    { 50, "Japan", "Town that has a famous fireworks show every summer, cute local shops and traditional Ryokan", "Matsue", 5, "Brittany" },
                    { 51, "Idk hawaii?", "Came expecting mystical underwater city, got some theme park, refund was not approved.", "Atlantis", 1, "Cody" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 51);
        }
    }
}
