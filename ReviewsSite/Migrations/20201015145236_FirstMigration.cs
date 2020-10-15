using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Review = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Category", "Description", "Image", "Name", "Review" },
                values: new object[] { 1, "Seafood", "Cleveland best seafood served on the best patio in town.", "", "Alley Cat Oyster Bar", "Top notch food and setting,the staff was friendly and knowledgable about the variety of seafood.Highly recommended." });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Category", "Description", "Image", "Name", "Review" },
                values: new object[] { 2, "Asian BBQ", "Asian food grilled for you in front of you", "", "bd's Mongolian Grill", "One of my favorite places to good for asian grilled food highly recommend" });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Category", "Description", "Image", "Name", "Review" },
                values: new object[] { 3, "Diner", "Upscale family restaurant", "", "Tommy's On Coventry", "By keeping its focus on balancing its menu between quality meat and vegetable entrees (and at an affordable price) Tommy's achieves its goal of creating  a watering hole where the carnivores and herbivores in your family can graze in peace." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Restaurants");
        }
    }
}
