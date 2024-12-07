using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JLara.SistemLang.Migrations
{
    /// <inheritdoc />
    public partial class entitiesrework : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppExercises_AbpUsers_UserId",
                table: "AppExercises");

            migrationBuilder.DropIndex(
                name: "IX_AppExercises_UserId",
                table: "AppExercises");

            migrationBuilder.DropColumn(
                name: "SugesstionCreationDate",
                table: "AppSugesstions");

            migrationBuilder.DropColumn(
                name: "DifficultyLevel",
                table: "AppProgresses");

            migrationBuilder.DropColumn(
                name: "PracticeDate",
                table: "AppProgresses");

            migrationBuilder.DropColumn(
                name: "Recommendation",
                table: "AppProgresses");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AppExercises");

            migrationBuilder.AddColumn<decimal>(
                name: "ProgressValue",
                table: "AppProgresses",
                type: "decimal(65,30)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phrase",
                table: "AppExercises",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AppUserExercises",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ExerciseId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    SugesstionId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserPhrase = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExtraProperties = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatorId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    LastModificationTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    DeletionTime = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserExercises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUserExercises_AppExercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "AppExercises",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppUserExercises_AppSugesstions_SugesstionId",
                        column: x => x.SugesstionId,
                        principalTable: "AppSugesstions",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserExercises_ExerciseId",
                table: "AppUserExercises",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserExercises_SugesstionId",
                table: "AppUserExercises",
                column: "SugesstionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUserExercises");

            migrationBuilder.DropColumn(
                name: "ProgressValue",
                table: "AppProgresses");

            migrationBuilder.AddColumn<DateTime>(
                name: "SugesstionCreationDate",
                table: "AppSugesstions",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DifficultyLevel",
                table: "AppProgresses",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "PracticeDate",
                table: "AppProgresses",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Recommendation",
                table: "AppProgresses",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "Phrase",
                table: "AppExercises",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "AppExercises",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_AppExercises_UserId",
                table: "AppExercises",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppExercises_AbpUsers_UserId",
                table: "AppExercises",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id");
        }
    }
}
