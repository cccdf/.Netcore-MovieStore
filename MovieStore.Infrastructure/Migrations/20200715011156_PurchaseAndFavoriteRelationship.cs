using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieStore.Infrastructure.Migrations
{
    public partial class PurchaseAndFavoriteRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "Review",
                type: "decimal(3, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(3, 2)",
                oldDefaultValue: 9.9m);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPrice",
                table: "Purchase",
                type: "decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "Review",
                type: "decimal(3, 2)",
                nullable: false,
                defaultValue: 9.9m,
                oldClrType: typeof(decimal),
                oldType: "decimal(3, 2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPrice",
                table: "Purchase",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)");
        }
    }
}
