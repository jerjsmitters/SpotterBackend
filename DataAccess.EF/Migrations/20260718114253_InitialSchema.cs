using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace DataAccess.EF.Migrations
{
    /// <inheritdoc />
    public partial class InitialSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Movements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movements", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "WorkoutTemplates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutTemplates", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MovementConfigurations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TotalSets = table.Column<int>(type: "int", nullable: false),
                    SetRepRangeLowerBound = table.Column<int>(type: "int", nullable: false),
                    SetRepRangeUpperBound = table.Column<int>(type: "int", nullable: false),
                    RestTimeSeconds = table.Column<int>(type: "int", nullable: false),
                    MovementId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovementConfigurations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovementConfigurations_Movements_MovementId",
                        column: x => x.MovementId,
                        principalTable: "Movements",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "WorkoutInstances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    WorkoutTemplateId = table.Column<int>(type: "int", nullable: false),
                    StartedDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CompletedDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutInstances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkoutInstances_WorkoutTemplates_WorkoutTemplateId",
                        column: x => x.WorkoutTemplateId,
                        principalTable: "WorkoutTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ConfiguredMovements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    MovementId = table.Column<int>(type: "int", nullable: false),
                    MovementConfigurationId = table.Column<int>(type: "int", nullable: false),
                    Sequence = table.Column<int>(type: "int", nullable: false),
                    WorkoutTemplateId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfiguredMovements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConfiguredMovements_MovementConfigurations_MovementConfigura~",
                        column: x => x.MovementConfigurationId,
                        principalTable: "MovementConfigurations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConfiguredMovements_Movements_MovementId",
                        column: x => x.MovementId,
                        principalTable: "Movements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConfiguredMovements_WorkoutTemplates_WorkoutTemplateId",
                        column: x => x.WorkoutTemplateId,
                        principalTable: "WorkoutTemplates",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "WorkoutInstanceMovements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ConfiguredMovementId = table.Column<int>(type: "int", nullable: false),
                    WorkoutInstanceId = table.Column<int>(type: "int", nullable: true),
                    StartedDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CompletedDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutInstanceMovements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkoutInstanceMovements_ConfiguredMovements_ConfiguredMovem~",
                        column: x => x.ConfiguredMovementId,
                        principalTable: "ConfiguredMovements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkoutInstanceMovements_WorkoutInstances_WorkoutInstanceId",
                        column: x => x.WorkoutInstanceId,
                        principalTable: "WorkoutInstances",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "WorkoutInstanceMovementSets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    SetNumber = table.Column<int>(type: "int", nullable: false),
                    Reps = table.Column<int>(type: "int", nullable: false),
                    WorkoutInstanceMovementId = table.Column<int>(type: "int", nullable: true),
                    StartedDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CompletedDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutInstanceMovementSets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkoutInstanceMovementSets_WorkoutInstanceMovements_Workout~",
                        column: x => x.WorkoutInstanceMovementId,
                        principalTable: "WorkoutInstanceMovements",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ConfiguredMovements_MovementConfigurationId",
                table: "ConfiguredMovements",
                column: "MovementConfigurationId");

            migrationBuilder.CreateIndex(
                name: "IX_ConfiguredMovements_MovementId",
                table: "ConfiguredMovements",
                column: "MovementId");

            migrationBuilder.CreateIndex(
                name: "IX_ConfiguredMovements_WorkoutTemplateId",
                table: "ConfiguredMovements",
                column: "WorkoutTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_MovementConfigurations_MovementId",
                table: "MovementConfigurations",
                column: "MovementId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutInstanceMovements_ConfiguredMovementId",
                table: "WorkoutInstanceMovements",
                column: "ConfiguredMovementId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutInstanceMovements_WorkoutInstanceId",
                table: "WorkoutInstanceMovements",
                column: "WorkoutInstanceId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutInstanceMovementSets_WorkoutInstanceMovementId",
                table: "WorkoutInstanceMovementSets",
                column: "WorkoutInstanceMovementId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutInstances_WorkoutTemplateId",
                table: "WorkoutInstances",
                column: "WorkoutTemplateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkoutInstanceMovementSets");

            migrationBuilder.DropTable(
                name: "WorkoutInstanceMovements");

            migrationBuilder.DropTable(
                name: "ConfiguredMovements");

            migrationBuilder.DropTable(
                name: "WorkoutInstances");

            migrationBuilder.DropTable(
                name: "MovementConfigurations");

            migrationBuilder.DropTable(
                name: "WorkoutTemplates");

            migrationBuilder.DropTable(
                name: "Movements");
        }
    }
}
