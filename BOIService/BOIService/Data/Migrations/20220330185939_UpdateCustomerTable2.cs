using Microsoft.EntityFrameworkCore.Migrations;

namespace BOIService.Migrations.Training
{
    public partial class UpdateCustomerTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PaymentTerm",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentTerm",
                table: "Customers");
        }
    }
}
