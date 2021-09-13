using Microsoft.EntityFrameworkCore.Migrations;

namespace WoodCalc_WPF.Migrations
{
    public partial class DataLoad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calculations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TypeOfCalculation = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calculations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Qualities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    QualityClass = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qualities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CalculationParameters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    E0 = table.Column<double>(type: "REAL", nullable: false),
                    E1 = table.Column<double>(type: "REAL", nullable: false),
                    E2 = table.Column<double>(type: "REAL", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    CalculationId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalculationParameters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CalculationParameters_Calculations_CalculationId",
                        column: x => x.CalculationId,
                        principalTable: "Calculations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TypeOfTree = table.Column<string>(type: "TEXT", nullable: true),
                    CalculationParametersId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trees_CalculationParameters_CalculationParametersId",
                        column: x => x.CalculationParametersId,
                        principalTable: "CalculationParameters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DiameterTop = table.Column<double>(type: "REAL", nullable: false),
                    DiameterMiddle = table.Column<double>(type: "REAL", nullable: false),
                    DiameterBottom = table.Column<double>(type: "REAL", nullable: false),
                    Volume = table.Column<double>(type: "REAL", nullable: false),
                    Length = table.Column<double>(type: "REAL", nullable: false),
                    Value = table.Column<double>(type: "REAL", nullable: false),
                    Bark = table.Column<double>(type: "REAL", nullable: false),
                    Tag = table.Column<string>(type: "TEXT", nullable: true),
                    QualityId = table.Column<int>(type: "INTEGER", nullable: true),
                    CalculationParametersId = table.Column<int>(type: "INTEGER", nullable: true),
                    CalculationId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Logs_Calculations_CalculationId",
                        column: x => x.CalculationId,
                        principalTable: "Calculations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Logs_Qualities_QualityId",
                        column: x => x.QualityId,
                        principalTable: "Qualities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Logs_Trees_CalculationParametersId",
                        column: x => x.CalculationParametersId,
                        principalTable: "Trees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Calculations",
                columns: new[] { "Id", "Description", "TypeOfCalculation" },
                values: new object[] { 1, null, "Huberův vzorec" });

            migrationBuilder.InsertData(
                table: "Calculations",
                columns: new[] { "Id", "Description", "TypeOfCalculation" },
                values: new object[] { 2, null, "Smalianův vzorec" });

            migrationBuilder.InsertData(
                table: "Calculations",
                columns: new[] { "Id", "Description", "TypeOfCalculation" },
                values: new object[] { 3, null, "Newtonův vzorec" });

            migrationBuilder.InsertData(
                table: "Calculations",
                columns: new[] { "Id", "Description", "TypeOfCalculation" },
                values: new object[] { 4, null, "ČSN 48 0007" });

            migrationBuilder.InsertData(
                table: "Calculations",
                columns: new[] { "Id", "Description", "TypeOfCalculation" },
                values: new object[] { 5, null, "ČSN 48 0009" });

            migrationBuilder.InsertData(
                table: "Qualities",
                columns: new[] { "Id", "QualityClass" },
                values: new object[] { 1, "A" });

            migrationBuilder.InsertData(
                table: "Qualities",
                columns: new[] { "Id", "QualityClass" },
                values: new object[] { 2, "B" });

            migrationBuilder.InsertData(
                table: "Qualities",
                columns: new[] { "Id", "QualityClass" },
                values: new object[] { 3, "C" });

            migrationBuilder.InsertData(
                table: "Qualities",
                columns: new[] { "Id", "QualityClass" },
                values: new object[] { 4, "D" });

            migrationBuilder.InsertData(
                table: "CalculationParameters",
                columns: new[] { "Id", "CalculationId", "E0", "E1", "E2", "Name" },
                values: new object[] { 1, 5, 0.57723000000000002, 0.0068970000000000004, 1.3123, "1. skupina" });

            migrationBuilder.InsertData(
                table: "CalculationParameters",
                columns: new[] { "Id", "CalculationId", "E0", "E1", "E2", "Name" },
                values: new object[] { 2, 5, 0.24016999999999999, 0.001915, 1.7866, "2. skupina" });

            migrationBuilder.InsertData(
                table: "CalculationParameters",
                columns: new[] { "Id", "CalculationId", "E0", "E1", "E2", "Name" },
                values: new object[] { 3, 5, 1.7015, 0.0087620000000000007, 1.4568000000000001, "3. skupina" });

            migrationBuilder.InsertData(
                table: "CalculationParameters",
                columns: new[] { "Id", "CalculationId", "E0", "E1", "E2", "Name" },
                values: new object[] { 4, 5, -0.04088, 0.16633999999999999, 0.56076000000000004, "4. skupina" });

            migrationBuilder.InsertData(
                table: "CalculationParameters",
                columns: new[] { "Id", "CalculationId", "E0", "E1", "E2", "Name" },
                values: new object[] { 5, 5, 1.2474000000000001, 0.042323, 1.0623, "5. skupina" });

            migrationBuilder.InsertData(
                table: "Trees",
                columns: new[] { "Id", "CalculationParametersId", "TypeOfTree" },
                values: new object[] { 1, 1, "smrk" });

            migrationBuilder.InsertData(
                table: "Trees",
                columns: new[] { "Id", "CalculationParametersId", "TypeOfTree" },
                values: new object[] { 17, 5, "jilm" });

            migrationBuilder.InsertData(
                table: "Trees",
                columns: new[] { "Id", "CalculationParametersId", "TypeOfTree" },
                values: new object[] { 16, 5, "jasan" });

            migrationBuilder.InsertData(
                table: "Trees",
                columns: new[] { "Id", "CalculationParametersId", "TypeOfTree" },
                values: new object[] { 15, 5, "dub" });

            migrationBuilder.InsertData(
                table: "Trees",
                columns: new[] { "Id", "CalculationParametersId", "TypeOfTree" },
                values: new object[] { 14, 5, "bříza" });

            migrationBuilder.InsertData(
                table: "Trees",
                columns: new[] { "Id", "CalculationParametersId", "TypeOfTree" },
                values: new object[] { 13, 4, "osika" });

            migrationBuilder.InsertData(
                table: "Trees",
                columns: new[] { "Id", "CalculationParametersId", "TypeOfTree" },
                values: new object[] { 12, 4, "lípa" });

            migrationBuilder.InsertData(
                table: "Trees",
                columns: new[] { "Id", "CalculationParametersId", "TypeOfTree" },
                values: new object[] { 11, 4, "jeřáb" });

            migrationBuilder.InsertData(
                table: "Trees",
                columns: new[] { "Id", "CalculationParametersId", "TypeOfTree" },
                values: new object[] { 18, 5, "olše" });

            migrationBuilder.InsertData(
                table: "Trees",
                columns: new[] { "Id", "CalculationParametersId", "TypeOfTree" },
                values: new object[] { 10, 4, "javor" });

            migrationBuilder.InsertData(
                table: "Trees",
                columns: new[] { "Id", "CalculationParametersId", "TypeOfTree" },
                values: new object[] { 8, 4, "buk" });

            migrationBuilder.InsertData(
                table: "Trees",
                columns: new[] { "Id", "CalculationParametersId", "TypeOfTree" },
                values: new object[] { 7, 3, "modřín" });

            migrationBuilder.InsertData(
                table: "Trees",
                columns: new[] { "Id", "CalculationParametersId", "TypeOfTree" },
                values: new object[] { 6, 3, "borovice - borka (oddenkové výřezy)" });

            migrationBuilder.InsertData(
                table: "Trees",
                columns: new[] { "Id", "CalculationParametersId", "TypeOfTree" },
                values: new object[] { 5, 2, "douglaska" });

            migrationBuilder.InsertData(
                table: "Trees",
                columns: new[] { "Id", "CalculationParametersId", "TypeOfTree" },
                values: new object[] { 4, 2, "borovice vejmutovka" });

            migrationBuilder.InsertData(
                table: "Trees",
                columns: new[] { "Id", "CalculationParametersId", "TypeOfTree" },
                values: new object[] { 3, 2, "borovice - kůra" });

            migrationBuilder.InsertData(
                table: "Trees",
                columns: new[] { "Id", "CalculationParametersId", "TypeOfTree" },
                values: new object[] { 2, 1, "jedle" });

            migrationBuilder.InsertData(
                table: "Trees",
                columns: new[] { "Id", "CalculationParametersId", "TypeOfTree" },
                values: new object[] { 9, 4, "habr" });

            migrationBuilder.InsertData(
                table: "Trees",
                columns: new[] { "Id", "CalculationParametersId", "TypeOfTree" },
                values: new object[] { 19, 5, "topol" });

            migrationBuilder.CreateIndex(
                name: "IX_CalculationParameters_CalculationId",
                table: "CalculationParameters",
                column: "CalculationId");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_CalculationId",
                table: "Logs",
                column: "CalculationId");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_CalculationParametersId",
                table: "Logs",
                column: "CalculationParametersId");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_QualityId",
                table: "Logs",
                column: "QualityId");

            migrationBuilder.CreateIndex(
                name: "IX_Trees_CalculationParametersId",
                table: "Trees",
                column: "CalculationParametersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "Qualities");

            migrationBuilder.DropTable(
                name: "Trees");

            migrationBuilder.DropTable(
                name: "CalculationParameters");

            migrationBuilder.DropTable(
                name: "Calculations");
        }
    }
}
