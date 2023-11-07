using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReservaDeHotel.Migrations
{
    /// <inheritdoc />
    public partial class relacaoPagamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagamento_ReservaHotel_ReservaHotelIdReserva",
                table: "Pagamento");

            migrationBuilder.DropColumn(
                name: "IdReservaEstadia",
                table: "Pagamento");

            migrationBuilder.RenameColumn(
                name: "ReservaHotelIdReserva",
                table: "Pagamento",
                newName: "ReservaIdReserva");

            migrationBuilder.RenameIndex(
                name: "IX_Pagamento_ReservaHotelIdReserva",
                table: "Pagamento",
                newName: "IX_Pagamento_ReservaIdReserva");

            migrationBuilder.AlterColumn<decimal>(
                name: "Valor",
                table: "Pagamento",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataPagamento",
                table: "Pagamento",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamento_ReservaHotel_ReservaIdReserva",
                table: "Pagamento",
                column: "ReservaIdReserva",
                principalTable: "ReservaHotel",
                principalColumn: "IdReserva");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagamento_ReservaHotel_ReservaIdReserva",
                table: "Pagamento");

            migrationBuilder.RenameColumn(
                name: "ReservaIdReserva",
                table: "Pagamento",
                newName: "ReservaHotelIdReserva");

            migrationBuilder.RenameIndex(
                name: "IX_Pagamento_ReservaIdReserva",
                table: "Pagamento",
                newName: "IX_Pagamento_ReservaHotelIdReserva");

            migrationBuilder.AlterColumn<decimal>(
                name: "Valor",
                table: "Pagamento",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataPagamento",
                table: "Pagamento",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdReservaEstadia",
                table: "Pagamento",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamento_ReservaHotel_ReservaHotelIdReserva",
                table: "Pagamento",
                column: "ReservaHotelIdReserva",
                principalTable: "ReservaHotel",
                principalColumn: "IdReserva");
        }
    }
}
