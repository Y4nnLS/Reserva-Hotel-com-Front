using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReservaDeHotel.Migrations
{
    /// <inheritdoc />
    public partial class gatinho : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservaHotel_EstadiaHotel_IdEstadia",
                table: "ReservaHotel");

            migrationBuilder.DropIndex(
                name: "IX_ReservaHotel_IdEstadia",
                table: "ReservaHotel");

            migrationBuilder.DropColumn(
                name: "IdEstadia",
                table: "ReservaHotel");

            migrationBuilder.DropColumn(
                name: "MetodoPagamento",
                table: "ReservaHotel");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "ReservaHotel");

            migrationBuilder.DropColumn(
                name: "Classificacao",
                table: "Hotel");

            migrationBuilder.AddColumn<int>(
                name: "EstadiaIdEstadia",
                table: "ReservaHotel",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReservaHotelIdReserva",
                table: "Pagamento",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReservaHotel_EstadiaIdEstadia",
                table: "ReservaHotel",
                column: "EstadiaIdEstadia");

            migrationBuilder.CreateIndex(
                name: "IX_Pagamento_ReservaHotelIdReserva",
                table: "Pagamento",
                column: "ReservaHotelIdReserva");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamento_ReservaHotel_ReservaHotelIdReserva",
                table: "Pagamento",
                column: "ReservaHotelIdReserva",
                principalTable: "ReservaHotel",
                principalColumn: "IdReserva");

            migrationBuilder.AddForeignKey(
                name: "FK_ReservaHotel_EstadiaHotel_EstadiaIdEstadia",
                table: "ReservaHotel",
                column: "EstadiaIdEstadia",
                principalTable: "EstadiaHotel",
                principalColumn: "IdEstadia");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagamento_ReservaHotel_ReservaHotelIdReserva",
                table: "Pagamento");

            migrationBuilder.DropForeignKey(
                name: "FK_ReservaHotel_EstadiaHotel_EstadiaIdEstadia",
                table: "ReservaHotel");

            migrationBuilder.DropIndex(
                name: "IX_ReservaHotel_EstadiaIdEstadia",
                table: "ReservaHotel");

            migrationBuilder.DropIndex(
                name: "IX_Pagamento_ReservaHotelIdReserva",
                table: "Pagamento");

            migrationBuilder.DropColumn(
                name: "EstadiaIdEstadia",
                table: "ReservaHotel");

            migrationBuilder.DropColumn(
                name: "ReservaHotelIdReserva",
                table: "Pagamento");

            migrationBuilder.AddColumn<int>(
                name: "IdEstadia",
                table: "ReservaHotel",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MetodoPagamento",
                table: "ReservaHotel",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Valor",
                table: "ReservaHotel",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Classificacao",
                table: "Hotel",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ReservaHotel_IdEstadia",
                table: "ReservaHotel",
                column: "IdEstadia");

            migrationBuilder.AddForeignKey(
                name: "FK_ReservaHotel_EstadiaHotel_IdEstadia",
                table: "ReservaHotel",
                column: "IdEstadia",
                principalTable: "EstadiaHotel",
                principalColumn: "IdEstadia",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
