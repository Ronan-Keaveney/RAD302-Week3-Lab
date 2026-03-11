using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RAD302Week3Lab12026CL.S00198790.Migrations
{
    /// <inheritdoc />
    public partial class SeedCustomerData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "Address", "CreditRating", "Name" },
                values: new object[,]
                {
                    { 1, "Galway", 700m, "John Murphy" },
                    { 2, "Dublin", 650m, "Mary Kelly" },
                    { 3, "Cork", 720m, "Tom O'Brien" },
                    { 4, "Limerick", 680m, "Sarah Walsh" },
                    { 5, "Waterford", 710m, "David Ryan" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 5);
        }
    }
}
