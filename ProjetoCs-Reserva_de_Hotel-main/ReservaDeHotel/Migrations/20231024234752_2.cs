using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReservaDeHotel.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Avaliacao_Hotel_HotelIDHotel",
                table: "Avaliacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagamento_ReservaHotel_ReservaHotelIdReserva",
                table: "Pagamento");

            migrationBuilder.DropIndex(
                name: "IX_Pagamento_ReservaHotelIdReserva",
                table: "Pagamento");

            migrationBuilder.DropIndex(
                name: "IX_Avaliacao_HotelIDHotel",
                table: "Avaliacao");

            migrationBuilder.DropColumn(
                name: "ReservaHotelIdReserva",
                table: "Pagamento");

            migrationBuilder.DropColumn(
                name: "HotelIDHotel",
                table: "Avaliacao");

            migrationBuilder.RenameColumn(
                name: "Login",
                table: "Cliente",
                newName: "Cpf");

            migrationBuilder.CreateIndex(
                name: "IX_Pagamento_IdReservaEstadia",
                table: "Pagamento",
                column: "IdReservaEstadia");

            migrationBuilder.CreateIndex(
                name: "IX_Comodidade_IDHotel",
                table: "Comodidade",
                column: "IDHotel");

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacao_IdHotel",
                table: "Avaliacao",
                column: "IdHotel");

            migrationBuilder.AddForeignKey(
                name: "FK_Avaliacao_Hotel_IdHotel",
                table: "Avaliacao",
                column: "IdHotel",
                principalTable: "Hotel",
                principalColumn: "IDHotel",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comodidade_Hotel_IDHotel",
                table: "Comodidade",
                column: "IDHotel",
                principalTable: "Hotel",
                principalColumn: "IDHotel",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamento_ReservaHotel_IdReservaEstadia",
                table: "Pagamento",
                column: "IdReservaEstadia",
                principalTable: "ReservaHotel",
                principalColumn: "IdReserva",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Avaliacao_Hotel_IdHotel",
                table: "Avaliacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Comodidade_Hotel_IDHotel",
                table: "Comodidade");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagamento_ReservaHotel_IdReservaEstadia",
                table: "Pagamento");

            migrationBuilder.DropIndex(
                name: "IX_Pagamento_IdReservaEstadia",
                table: "Pagamento");

            migrationBuilder.DropIndex(
                name: "IX_Comodidade_IDHotel",
                table: "Comodidade");

            migrationBuilder.DropIndex(
                name: "IX_Avaliacao_IdHotel",
                table: "Avaliacao");

            migrationBuilder.RenameColumn(
                name: "Cpf",
                table: "Cliente",
                newName: "Login");

            migrationBuilder.AddColumn<int>(
                name: "ReservaHotelIdReserva",
                table: "Pagamento",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HotelIDHotel",
                table: "Avaliacao",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pagamento_ReservaHotelIdReserva",
                table: "Pagamento",
                column: "ReservaHotelIdReserva");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamento_ReservaHotel_ReservaHotelIdReserva",
                table: "Pagamento",
                column: "ReservaHotelIdReserva",
                principalTable: "ReservaHotel",
                principalColumn: "IdReserva");
        }
    }
}
