using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Musicapp_backend.Migrations
{
    /// <inheritdoc />
    public partial class CategoryMigration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_song_category",
                table: "song");

            migrationBuilder.AlterColumn<int>(
                name: "category_id",
                table: "song",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "fk_song_category",
                table: "song",
                column: "category_id",
                principalTable: "category",
                principalColumn: "category_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_song_category",
                table: "song");

            migrationBuilder.AlterColumn<int>(
                name: "category_id",
                table: "song",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "fk_song_category",
                table: "song",
                column: "category_id",
                principalTable: "category",
                principalColumn: "category_id");
        }
    }
}
