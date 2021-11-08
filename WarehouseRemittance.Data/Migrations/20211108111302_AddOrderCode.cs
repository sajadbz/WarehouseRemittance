using Microsoft.EntityFrameworkCore.Migrations;

namespace WarehouseRemittance.Data.Migrations
{
    public partial class AddOrderCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderCode",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderCode",
                table: "Orders");
        }
    }
}
