using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBusinessApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Resturants",
                columns: new[] { "ResturantId", "KeyBusiness", "Name", "StreetAddress" },
                values: new object[,]
                {
                    { 1, "Late night bites", "24hr Kabab", "151 High St" },
                    { 2, "Casual drinks & street food", "Maria's Cantina", "132 High St" },
                    { 3, "Italian dining", "Pastini Ristorante", "222 Old Town Ave" },
                    { 4, "Beer on tap & pub food", "O'Leary's Pub", "100 High St" },
                    { 5, "French cuisine", "Pierre's Bon Cuisine", "1310 Rue St Jean" }
                });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "ShopId", "KeyBusiness", "Name", "StreetAddress" },
                values: new object[,]
                {
                    { 1, "Record Shop", "Ricc's Records", "123 Groovy Way" },
                    { 2, "Professional Audio", "Aubrey's Amps & LoudSpeakers", "666 Industry Ave" },
                    { 3, "Plant Shop", "Les Fluers", "1300 Rue St Jean" },
                    { 4, "Antiques", "Auntie A's Antiques", "44 Junk St" },
                    { 5, "Convenience Store", "General Store", "15 Old Town Ave" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Resturants",
                keyColumn: "ResturantId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Resturants",
                keyColumn: "ResturantId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Resturants",
                keyColumn: "ResturantId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Resturants",
                keyColumn: "ResturantId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Resturants",
                keyColumn: "ResturantId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: 5);
        }
    }
}
