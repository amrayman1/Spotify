using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Profile_and_Singers.Migrations
{
    public partial class IntialCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "musics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublicId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_musics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "singerMusics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SingerId = table.Column<int>(type: "int", nullable: false),
                    MusicId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_singerMusics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "singers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_singers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MusicSingerMusic",
                columns: table => new
                {
                    musicsId = table.Column<int>(type: "int", nullable: false),
                    singerMusicsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicSingerMusic", x => new { x.musicsId, x.singerMusicsId });
                    table.ForeignKey(
                        name: "FK_MusicSingerMusic_musics_musicsId",
                        column: x => x.musicsId,
                        principalTable: "musics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MusicSingerMusic_singerMusics_singerMusicsId",
                        column: x => x.singerMusicsId,
                        principalTable: "singerMusics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SingerSingerMusic",
                columns: table => new
                {
                    singerMusicsId = table.Column<int>(type: "int", nullable: false),
                    singersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SingerSingerMusic", x => new { x.singerMusicsId, x.singersId });
                    table.ForeignKey(
                        name: "FK_SingerSingerMusic_singerMusics_singerMusicsId",
                        column: x => x.singerMusicsId,
                        principalTable: "singerMusics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SingerSingerMusic_singers_singersId",
                        column: x => x.singersId,
                        principalTable: "singers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MusicSingerMusic_singerMusicsId",
                table: "MusicSingerMusic",
                column: "singerMusicsId");

            migrationBuilder.CreateIndex(
                name: "IX_SingerSingerMusic_singersId",
                table: "SingerSingerMusic",
                column: "singersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MusicSingerMusic");

            migrationBuilder.DropTable(
                name: "SingerSingerMusic");

            migrationBuilder.DropTable(
                name: "musics");

            migrationBuilder.DropTable(
                name: "singerMusics");

            migrationBuilder.DropTable(
                name: "singers");
        }
    }
}
