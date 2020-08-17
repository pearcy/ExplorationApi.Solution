using Microsoft.EntityFrameworkCore.Migrations;

namespace ExplorationApi.Solution.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "PlaceId", "Country", "Description", "Name", "Rating", "UserName" },
                values: new object[,]
                {
                    { 1, "Mexico", "A warm sunny town with lots of good food carts and food fresh from the ocean.", "Puerta Vallarta", 5, "Brittany" },
                    { 2, "USA", "A little town on the Oregon coast with beautiful views of the ocean and one brewery.", "Yachats", 4, "Brittany" },
                    { 3, "USA", "Not that scenic and way too crowded to enjoy, unless you have a boat or some other watercraft.", "Timothy Lake", 2, "Kate" },
                    { 4, "Mexico", "There was a hurricane! Was there for a wedding that had to be postponed.", "Puerta Vallarta", 1, "Kate" },
                    { 5, "France", "A beautiful little town outside of Gorges du Verdon. Great views and restaurants.", "La Palud sur Verdon", 5, "Kate" },
                    { 6, "Japan", "Town that has a famous fireworks show every summer, cute local shops and traditional Ryokan", "Matsue", 5, "Brittany" },
                    { 7, "Idk hawaii?", "Came expecting mystical underwater city, got some theme park, refund was not approved.", "Atlantis", 1, "Cody" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 7);
        }
    }
}
