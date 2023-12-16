using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class CompatibleZodiacsNullable1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompatibleZodiacs_Zodiacs_ZodiacId",
                table: "CompatibleZodiacs");

            migrationBuilder.DropIndex(
                name: "IX_CompatibleZodiacs_ZodiacId",
                table: "CompatibleZodiacs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_CompatibleZodiacs_ZodiacId",
                table: "CompatibleZodiacs",
                column: "ZodiacId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompatibleZodiacs_Zodiacs_ZodiacId",
                table: "CompatibleZodiacs",
                column: "ZodiacId",
                principalTable: "Zodiacs",
                principalColumn: "Id");
        }
    }
}
