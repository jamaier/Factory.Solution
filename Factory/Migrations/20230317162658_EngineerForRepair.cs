using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Factory.Migrations
{
    public partial class EngineerForRepair : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RepairId",
                table: "Engineers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Engineers_RepairId",
                table: "Engineers",
                column: "RepairId");

            migrationBuilder.AddForeignKey(
                name: "FK_Engineers_Repair_RepairId",
                table: "Engineers",
                column: "RepairId",
                principalTable: "Repair",
                principalColumn: "RepairId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Engineers_Repair_RepairId",
                table: "Engineers");

            migrationBuilder.DropIndex(
                name: "IX_Engineers_RepairId",
                table: "Engineers");

            migrationBuilder.DropColumn(
                name: "RepairId",
                table: "Engineers");
        }
    }
}
