using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class CompatibleZodiacs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompatibleZodiacs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZodiacId = table.Column<int>(type: "int", nullable: false),
                    CompatibleZodiacId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompatibleZodiacs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompatibleZodiacs_Zodiacs_CompatibleZodiacId",
                        column: x => x.CompatibleZodiacId,
                        principalTable: "Zodiacs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompatibleZodiacs_Zodiacs_ZodiacId",
                        column: x => x.ZodiacId,
                        principalTable: "Zodiacs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompatibleZodiacs_CompatibleZodiacId",
                table: "CompatibleZodiacs",
                column: "CompatibleZodiacId");

            migrationBuilder.CreateIndex(
                name: "IX_CompatibleZodiacs_ZodiacId",
                table: "CompatibleZodiacs",
                column: "ZodiacId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompatibleZodiacs");
        }
    }
}
