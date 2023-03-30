using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Musicapp_backend.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "category",
                columns: table => new
                {
                    category_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    category_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category", x => x.category_id);
                });

            migrationBuilder.CreateTable(
                name: "song",
                columns: table => new
                {
                    song_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    song_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    song_artist = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    song_url = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    song_rating = table.Column<int>(type: "int", nullable: true),
                    is_favourite = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    edited_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    category_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_song", x => x.song_id);
                    table.ForeignKey(
                        name: "fk_song_category",
                        column: x => x.category_id,
                        principalTable: "category",
                        principalColumn: "category_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_song_category_id",
                table: "song",
                column: "category_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "song");

            migrationBuilder.DropTable(
                name: "category");
        }
    }
}
