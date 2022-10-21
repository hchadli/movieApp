using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class DateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "TvShowSeasons",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "TvShows",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "TvShowEpisodes",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Movies",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Actors",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "TvShowSeasons",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "TvShows",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "TvShowEpisodes",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Actors",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");
        }
    }
}
