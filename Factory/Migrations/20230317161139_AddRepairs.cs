using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Factory.Migrations
{
    public partial class AddRepairs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Engineers_MachineId",
                table: "Engineers");

            migrationBuilder.AddColumn<int>(
                name: "RepairId",
                table: "Machines",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Repair",
                columns: table => new
                {
                    RepairId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RepairDetails = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repair", x => x.RepairId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MachineRepair",
                columns: table => new
                {
                    MachineRepairId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MachineId = table.Column<int>(type: "int", nullable: false),
                    RepairId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachineRepair", x => x.MachineRepairId);
                    table.ForeignKey(
                        name: "FK_MachineRepair_Machines_MachineId",
                        column: x => x.MachineId,
                        principalTable: "Machines",
                        principalColumn: "MachineId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MachineRepair_Repair_RepairId",
                        column: x => x.RepairId,
                        principalTable: "Repair",
                        principalColumn: "RepairId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Machines_RepairId",
                table: "Machines",
                column: "RepairId");

            migrationBuilder.CreateIndex(
                name: "IX_Engineers_MachineId",
                table: "Engineers",
                column: "MachineId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MachineRepair_MachineId",
                table: "MachineRepair",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_MachineRepair_RepairId",
                table: "MachineRepair",
                column: "RepairId");

            migrationBuilder.AddForeignKey(
                name: "FK_Machines_Repair_RepairId",
                table: "Machines",
                column: "RepairId",
                principalTable: "Repair",
                principalColumn: "RepairId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Machines_Repair_RepairId",
                table: "Machines");

            migrationBuilder.DropTable(
                name: "MachineRepair");

            migrationBuilder.DropTable(
                name: "Repair");

            migrationBuilder.DropIndex(
                name: "IX_Machines_RepairId",
                table: "Machines");

            migrationBuilder.DropIndex(
                name: "IX_Engineers_MachineId",
                table: "Engineers");

            migrationBuilder.DropColumn(
                name: "RepairId",
                table: "Machines");

            migrationBuilder.CreateIndex(
                name: "IX_Engineers_MachineId",
                table: "Engineers",
                column: "MachineId");
        }
    }
}
