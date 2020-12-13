using System;
using System.IO;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IndianMovies.Migrations
{
    public partial class IndianMovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Movie_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Movie_Name = table.Column<string>(nullable: true),
                    Director_Name = table.Column<string>(nullable: true),
                    Actor_Name = table.Column<string>(nullable: true),
                    Actress_Name = table.Column<string>(nullable: true),
                    Release_Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Movie_Id);
                });

            migrationBuilder.CreateTable(
                name: "MoviesCollection",
                columns: table => new
                {
                    Moviescollection_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Movie_Name = table.Column<string>(nullable: true),
                    India = table.Column<string>(nullable: true),
                    Canada = table.Column<string>(nullable: true),
                    Australia = table.Column<string>(nullable: true),
                    Movie_ID = table.Column<int>(nullable: false),
                    Movie_objMovie_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoviesCollection", x => x.Moviescollection_Id);
                    table.ForeignKey(
                        name: "FK_MoviesCollection_Movies_Movie_objMovie_Id",
                        column: x => x.Movie_objMovie_Id,
                        principalTable: "Movies",
                        principalColumn: "Movie_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ranking",
                columns: table => new
                {
                    Ranking_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Movie_Name = table.Column<string>(nullable: true),
                    India = table.Column<string>(nullable: true),
                    Canada = table.Column<string>(nullable: true),
                    Australia = table.Column<string>(nullable: true),
                    Movie_ID = table.Column<int>(nullable: false),
                    Movie_objMovie_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ranking", x => x.Ranking_Id);
                    table.ForeignKey(
                        name: "FK_Ranking_Movies_Movie_objMovie_Id",
                        column: x => x.Movie_objMovie_Id,
                        principalTable: "Movies",
                        principalColumn: "Movie_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UpcomingMovies",
                columns: table => new
                {
                    UpcomingMovies_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Movie_Name = table.Column<string>(nullable: true),
                    Movie_Type = table.Column<string>(nullable: true),
                    Release_Date = table.Column<DateTime>(nullable: false),
                    Movie_ID = table.Column<int>(nullable: false),
                    Movie_objMovie_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpcomingMovies", x => x.UpcomingMovies_Id);
                    table.ForeignKey(
                        name: "FK_UpcomingMovies_Movies_Movie_objMovie_Id",
                        column: x => x.Movie_objMovie_Id,
                        principalTable: "Movies",
                        principalColumn: "Movie_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MoviesCollection_Movie_objMovie_Id",
                table: "MoviesCollection",
                column: "Movie_objMovie_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Ranking_Movie_objMovie_Id",
                table: "Ranking",
                column: "Movie_objMovie_Id");

            migrationBuilder.CreateIndex(
                name: "IX_UpcomingMovies_Movie_objMovie_Id",
                table: "UpcomingMovies",
                column: "Movie_objMovie_Id");

            var sqlFile = Path.Combine(".\\DatabaseScript", @"data.sql");
            migrationBuilder.Sql(File.ReadAllText(sqlFile));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MoviesCollection");

            migrationBuilder.DropTable(
                name: "Ranking");

            migrationBuilder.DropTable(
                name: "UpcomingMovies");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
