using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Factory.Migrations
{
    public partial class EngineerToRepairs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MachineRepair_Engineers_EngineerId",
                table: "MachineRepair");

            migrationBuilder.AlterColumn<int>(
                name: "EngineerId",
                table: "MachineRepair",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MachineRepair_Engineers_EngineerId",
                table: "MachineRepair",
                column: "EngineerId",
                principalTable: "Engineers",
                principalColumn: "EngineerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MachineRepair_Engineers_EngineerId",
                table: "MachineRepair");

            migrationBuilder.AlterColumn<int>(
                name: "EngineerId",
                table: "MachineRepair",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_MachineRepair_Engineers_EngineerId",
                table: "MachineRepair",
                column: "EngineerId",
                principalTable: "Engineers",
                principalColumn: "EngineerId");
        }
    }
}
