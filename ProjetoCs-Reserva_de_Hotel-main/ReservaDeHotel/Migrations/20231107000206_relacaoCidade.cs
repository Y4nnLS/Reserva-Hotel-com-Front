using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReservaDeHotel.Migrations
{
    /// <inheritdoc />
    public partial class relacaoCidade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Avaliacao_Hotel_HotelId",
                table: "Avaliacao");

            migrationBuilder.AlterColumn<int>(
                name: "HotelId",
                table: "Avaliacao",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Avaliacao_Hotel_HotelId",
                table: "Avaliacao",
                column: "HotelId",
                principalTable: "Hotel",
                principalColumn: "IDHotel");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Avaliacao_Hotel_HotelId",
                table: "Avaliacao");

            migrationBuilder.AlterColumn<int>(
                name: "HotelId",
                table: "Avaliacao",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Avaliacao_Hotel_HotelId",
                table: "Avaliacao",
                column: "HotelId",
                principalTable: "Hotel",
                principalColumn: "IDHotel",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
