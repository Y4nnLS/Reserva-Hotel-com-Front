using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReservaDeHotel.Migrations
{
    /// <inheritdoc />
    public partial class d : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comodidade_Hotel_HotelIDHotel",
                table: "Comodidade");

            migrationBuilder.DropIndex(
                name: "IX_Comodidade_HotelIDHotel",
                table: "Comodidade");

            migrationBuilder.DropColumn(
                name: "HotelIDHotel",
                table: "Comodidade");

            migrationBuilder.AddColumn<string>(
                name: "ListaDeQuartos",
                table: "Hotel",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecoPorNoite",
                table: "Comodidade",
                type: "decimal(6,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ListaDeQuartos",
                table: "Hotel");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecoPorNoite",
                table: "Comodidade",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,2)");

            migrationBuilder.AddColumn<int>(
                name: "HotelIDHotel",
                table: "Comodidade",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comodidade_HotelIDHotel",
                table: "Comodidade",
                column: "HotelIDHotel");

            migrationBuilder.AddForeignKey(
                name: "FK_Comodidade_Hotel_HotelIDHotel",
                table: "Comodidade",
                column: "HotelIDHotel",
                principalTable: "Hotel",
                principalColumn: "IDHotel");
        }
    }
}
