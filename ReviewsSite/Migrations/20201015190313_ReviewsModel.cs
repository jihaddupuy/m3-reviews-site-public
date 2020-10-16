using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class ReviewsModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Review",
                table: "Restaurants");

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(nullable: true),
                    RestaurantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "RestaurantId" },
                values: new object[] { 1, "Top notch food and setting,the staff was friendly and knowledgable about the variety of seafood.Highly recommended.", 1 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "RestaurantId" },
                values: new object[] { 2, "One of my favorite places to go for good asian grilled food, highly recommended", 2 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "RestaurantId" },
                values: new object[] { 3, "By keeping its focus on balancing its menu between quality meat and vegetable entrees (and at an affordable price) Tommy's achieves its goal of creating  a watering hole where the carnivores and herbivores in your family can graze in peace.", 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_RestaurantId",
                table: "Reviews",
                column: "RestaurantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.AddColumn<string>(
                name: "Review",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Review",
                value: "Top notch food and setting,the staff was friendly and knowledgable about the variety of seafood.Highly recommended.");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                column: "Review",
                value: "One of my favorite places to good for asian grilled food highly recommend");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                column: "Review",
                value: "By keeping its focus on balancing its menu between quality meat and vegetable entrees (and at an affordable price) Tommy's achieves its goal of creating  a watering hole where the carnivores and herbivores in your family can graze in peace.");
        }
    }
}
