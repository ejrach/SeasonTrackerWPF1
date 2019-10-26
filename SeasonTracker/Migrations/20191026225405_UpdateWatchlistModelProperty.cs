using Microsoft.EntityFrameworkCore.Migrations;

namespace SeasonTracker.Migrations
{
    public partial class UpdateWatchlistModelProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Viewlist",
                table: "Watchlists");

            migrationBuilder.AddColumn<string>(
                name: "EpisodeViewlist",
                table: "Watchlists",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EpisodeViewlist",
                table: "Watchlists");

            migrationBuilder.AddColumn<string>(
                name: "Viewlist",
                table: "Watchlists",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
