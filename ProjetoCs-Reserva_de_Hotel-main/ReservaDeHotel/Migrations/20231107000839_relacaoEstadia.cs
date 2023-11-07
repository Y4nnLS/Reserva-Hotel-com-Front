using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReservaDeHotel.Migrations
{
    /// <inheritdoc />
    public partial class relacaoEstadia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservaHotel_EstadiaHotel_EstadiaIdEstadia",
                table: "ReservaHotel");

            migrationBuilder.DropIndex(
                name: "IX_ReservaHotel_EstadiaIdEstadia",
                table: "ReservaHotel");

            migrationBuilder.DropColumn(
                name: "EstadiaIdEstadia",
                table: "ReservaHotel");

            migrationBuilder.AddColumn<int>(
                name: "PagamentoIdPagamento",
                table: "Pagamento",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "QtdQuartos",
                table: "EstadiaHotel",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataSaida",
                table: "EstadiaHotel",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataEntrada",
                table: "EstadiaHotel",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.CreateTable(
                name: "EstadiaHotelReservaHotel",
                columns: table => new
                {
                    EstadiasIdEstadia = table.Column<int>(type: "INTEGER", nullable: false),
                    ReservasIdReserva = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadiaHotelReservaHotel", x => new { x.EstadiasIdEstadia, x.ReservasIdReserva });
                    table.ForeignKey(
                        name: "FK_EstadiaHotelReservaHotel_EstadiaHotel_EstadiasIdEstadia",
                        column: x => x.EstadiasIdEstadia,
                        principalTable: "EstadiaHotel",
                        principalColumn: "IdEstadia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EstadiaHotelReservaHotel_ReservaHotel_ReservasIdReserva",
                        column: x => x.ReservasIdReserva,
                        principalTable: "ReservaHotel",
                        principalColumn: "IdReserva",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pagamento_PagamentoIdPagamento",
                table: "Pagamento",
                column: "PagamentoIdPagamento");

            migrationBuilder.CreateIndex(
                name: "IX_EstadiaHotelReservaHotel_ReservasIdReserva",
                table: "EstadiaHotelReservaHotel",
                column: "ReservasIdReserva");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamento_Pagamento_PagamentoIdPagamento",
                table: "Pagamento",
                column: "PagamentoIdPagamento",
                principalTable: "Pagamento",
                principalColumn: "IdPagamento");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagamento_Pagamento_PagamentoIdPagamento",
                table: "Pagamento");

            migrationBuilder.DropTable(
                name: "EstadiaHotelReservaHotel");

            migrationBuilder.DropIndex(
                name: "IX_Pagamento_PagamentoIdPagamento",
                table: "Pagamento");

            migrationBuilder.DropColumn(
                name: "PagamentoIdPagamento",
                table: "Pagamento");

            migrationBuilder.AddColumn<int>(
                name: "EstadiaIdEstadia",
                table: "ReservaHotel",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "QtdQuartos",
                table: "EstadiaHotel",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataSaida",
                table: "EstadiaHotel",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataEntrada",
                table: "EstadiaHotel",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReservaHotel_EstadiaIdEstadia",
                table: "ReservaHotel",
                column: "EstadiaIdEstadia");

            migrationBuilder.AddForeignKey(
                name: "FK_ReservaHotel_EstadiaHotel_EstadiaIdEstadia",
                table: "ReservaHotel",
                column: "EstadiaIdEstadia",
                principalTable: "EstadiaHotel",
                principalColumn: "IdEstadia");
        }
    }
}
