using Microsoft.EntityFrameworkCore.Migrations;

namespace WeightliftingList.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Weights",
                columns: new[] { "WeightId", "Brand", "Material", "Pounds", "WeightType" },
                values: new object[,]
                {
                    { 1, "Rogue Fitness", "Steel", 45, "Barbell" },
                    { 2, "Rogue Fitness", "Steel", 25, "Dumbbell" },
                    { 3, "Rogue Fitness", "Coated Steel", 40, "Kettlebell" },
                    { 4, "Rogue Fitness", "Steel", 20, "Ez Curl Bar" },
                    { 5, "Rogue Fitness", "Steel", 55, "Deadlift Bar" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Weights",
                keyColumn: "WeightId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Weights",
                keyColumn: "WeightId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Weights",
                keyColumn: "WeightId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Weights",
                keyColumn: "WeightId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Weights",
                keyColumn: "WeightId",
                keyValue: 5);
        }
    }
}
