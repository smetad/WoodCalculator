using Microsoft.EntityFrameworkCore.Migrations;

namespace woodcalc_00.Migrations
{
    public partial class TreeTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Logs_Trees_CalculationParametersId",
                table: "Logs");

            migrationBuilder.RenameColumn(
                name: "CalculationParametersId",
                table: "Logs",
                newName: "TreeId");

            migrationBuilder.RenameIndex(
                name: "IX_Logs_CalculationParametersId",
                table: "Logs",
                newName: "IX_Logs_TreeId");

            migrationBuilder.AlterColumn<string>(
                name: "TypeOfCalculation",
                table: "Calculations",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_Trees_TreeId",
                table: "Logs",
                column: "TreeId",
                principalTable: "Trees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Logs_Trees_TreeId",
                table: "Logs");

            migrationBuilder.RenameColumn(
                name: "TreeId",
                table: "Logs",
                newName: "CalculationParametersId");

            migrationBuilder.RenameIndex(
                name: "IX_Logs_TreeId",
                table: "Logs",
                newName: "IX_Logs_CalculationParametersId");

            migrationBuilder.AlterColumn<string>(
                name: "TypeOfCalculation",
                table: "Calculations",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_Trees_CalculationParametersId",
                table: "Logs",
                column: "CalculationParametersId",
                principalTable: "Trees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
