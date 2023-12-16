using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class CompatibleZodiacsNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompatibleZodiacs_Zodiacs_CompatibleZodiacId",
                table: "CompatibleZodiacs");

            migrationBuilder.DropForeignKey(
                name: "FK_CompatibleZodiacs_Zodiacs_ZodiacId",
                table: "CompatibleZodiacs");

            migrationBuilder.AlterColumn<int>(
                name: "ZodiacId",
                table: "CompatibleZodiacs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CompatibleZodiacId",
                table: "CompatibleZodiacs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_CompatibleZodiacs_Zodiacs_CompatibleZodiacId",
                table: "CompatibleZodiacs",
                column: "CompatibleZodiacId",
                principalTable: "Zodiacs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CompatibleZodiacs_Zodiacs_ZodiacId",
                table: "CompatibleZodiacs",
                column: "ZodiacId",
                principalTable: "Zodiacs",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompatibleZodiacs_Zodiacs_CompatibleZodiacId",
                table: "CompatibleZodiacs");

            migrationBuilder.DropForeignKey(
                name: "FK_CompatibleZodiacs_Zodiacs_ZodiacId",
                table: "CompatibleZodiacs");

            migrationBuilder.AlterColumn<int>(
                name: "ZodiacId",
                table: "CompatibleZodiacs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompatibleZodiacId",
                table: "CompatibleZodiacs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CompatibleZodiacs_Zodiacs_CompatibleZodiacId",
                table: "CompatibleZodiacs",
                column: "CompatibleZodiacId",
                principalTable: "Zodiacs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompatibleZodiacs_Zodiacs_ZodiacId",
                table: "CompatibleZodiacs",
                column: "ZodiacId",
                principalTable: "Zodiacs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
