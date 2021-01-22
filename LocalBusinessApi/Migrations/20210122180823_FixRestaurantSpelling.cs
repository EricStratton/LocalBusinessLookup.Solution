using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBusinessApi.Migrations
{
    public partial class FixRestaurantSpelling : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Resturants");

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    RestaurantId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    KeyBusiness = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.RestaurantId);
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "KeyBusiness", "Name", "StreetAddress" },
                values: new object[,]
                {
                    { 1, "Late night bites", "24hr Kabab", "151 High St" },
                    { 2, "Casual drinks & street food", "Maria's Cantina", "132 High St" },
                    { 3, "Italian dining", "Pastini Ristorante", "222 Old Town Ave" },
                    { 4, "Beer on tap & pub food", "O'Leary's Pub", "100 High St" },
                    { 5, "French cuisine", "Pierre's Bon Cuisine", "1310 Rue St Jean" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.CreateTable(
                name: "Resturants",
                columns: table => new
                {
                    ResturantId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    KeyBusiness = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resturants", x => x.ResturantId);
                });

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
        }
    }
}
