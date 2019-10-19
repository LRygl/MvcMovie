using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Migrations
{
    public partial class updateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "directorID",
                table: "Movies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Directors",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Directors_MovieId",
                table: "Directors",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Directors_Movies_MovieId",
                table: "Directors",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Directors_Movies_MovieId",
                table: "Directors");

            migrationBuilder.DropIndex(
                name: "IX_Directors_MovieId",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "directorID",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Directors");
        }
    }
}
