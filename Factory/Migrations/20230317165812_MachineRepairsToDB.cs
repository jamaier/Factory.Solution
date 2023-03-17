using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Factory.Migrations
{
    public partial class MachineRepairsToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Engineers_Repair_RepairId",
                table: "Engineers");

            migrationBuilder.DropForeignKey(
                name: "FK_MachineRepair_Repair_RepairId",
                table: "MachineRepair");

            migrationBuilder.DropForeignKey(
                name: "FK_Machines_Repair_RepairId",
                table: "Machines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Repair",
                table: "Repair");

            migrationBuilder.RenameTable(
                name: "Repair",
                newName: "Repairs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Repairs",
                table: "Repairs",
                column: "RepairId");

            migrationBuilder.AddForeignKey(
                name: "FK_Engineers_Repairs_RepairId",
                table: "Engineers",
                column: "RepairId",
                principalTable: "Repairs",
                principalColumn: "RepairId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MachineRepair_Repairs_RepairId",
                table: "MachineRepair",
                column: "RepairId",
                principalTable: "Repairs",
                principalColumn: "RepairId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Machines_Repairs_RepairId",
                table: "Machines",
                column: "RepairId",
                principalTable: "Repairs",
                principalColumn: "RepairId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Engineers_Repairs_RepairId",
                table: "Engineers");

            migrationBuilder.DropForeignKey(
                name: "FK_MachineRepair_Repairs_RepairId",
                table: "MachineRepair");

            migrationBuilder.DropForeignKey(
                name: "FK_Machines_Repairs_RepairId",
                table: "Machines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Repairs",
                table: "Repairs");

            migrationBuilder.RenameTable(
                name: "Repairs",
                newName: "Repair");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Repair",
                table: "Repair",
                column: "RepairId");

            migrationBuilder.AddForeignKey(
                name: "FK_Engineers_Repair_RepairId",
                table: "Engineers",
                column: "RepairId",
                principalTable: "Repair",
                principalColumn: "RepairId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MachineRepair_Repair_RepairId",
                table: "MachineRepair",
                column: "RepairId",
                principalTable: "Repair",
                principalColumn: "RepairId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Machines_Repair_RepairId",
                table: "Machines",
                column: "RepairId",
                principalTable: "Repair",
                principalColumn: "RepairId");
        }
    }
}
