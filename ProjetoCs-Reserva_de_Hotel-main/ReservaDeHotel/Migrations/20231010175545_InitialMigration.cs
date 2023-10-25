using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReservaDeHotel.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HotelIDHotel",
                table: "Avaliacao",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacao_HotelIDHotel",
                table: "Avaliacao",
                column: "HotelIDHotel");

            migrationBuilder.AddForeignKey(
                name: "FK_Avaliacao_Hotel_HotelIDHotel",
                table: "Avaliacao",
                column: "HotelIDHotel",
                principalTable: "Hotel",
                principalColumn: "IDHotel");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Avaliacao_Hotel_HotelIDHotel",
                table: "Avaliacao");

            migrationBuilder.DropIndex(
                name: "IX_Avaliacao_HotelIDHotel",
                table: "Avaliacao");

            migrationBuilder.DropColumn(
                name: "HotelIDHotel",
                table: "Avaliacao");
        }
    }
}
