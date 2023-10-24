using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReservaDeHotel.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ListaHoteis",
                table: "Cidade");

            migrationBuilder.AddColumn<int>(
                name: "CidadeIdCidade",
                table: "Hotel",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EstadiaHotel",
                columns: table => new
                {
                    IdEstadia = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    QtdQuartos = table.Column<int>(type: "INTEGER", nullable: false),
                    DataEntrada = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataSaida = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadiaHotel", x => x.IdEstadia);
                });

            migrationBuilder.CreateTable(
                name: "ReservaHotel",
                columns: table => new
                {
                    IdReserva = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeHospede = table.Column<string>(type: "TEXT", nullable: true),
                    MetodoPagamento = table.Column<string>(type: "TEXT", nullable: true),
                    Valor = table.Column<decimal>(type: "TEXT", nullable: false),
                    IdEstadia = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservaHotel", x => x.IdReserva);
                    table.ForeignKey(
                        name: "FK_ReservaHotel_EstadiaHotel_IdEstadia",
                        column: x => x.IdEstadia,
                        principalTable: "EstadiaHotel",
                        principalColumn: "IdEstadia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_CidadeIdCidade",
                table: "Hotel",
                column: "CidadeIdCidade");

            migrationBuilder.CreateIndex(
                name: "IX_ReservaHotel_IdEstadia",
                table: "ReservaHotel",
                column: "IdEstadia");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotel_Cidade_CidadeIdCidade",
                table: "Hotel",
                column: "CidadeIdCidade",
                principalTable: "Cidade",
                principalColumn: "IdCidade");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotel_Cidade_CidadeIdCidade",
                table: "Hotel");

            migrationBuilder.DropTable(
                name: "ReservaHotel");

            migrationBuilder.DropTable(
                name: "EstadiaHotel");

            migrationBuilder.DropIndex(
                name: "IX_Hotel_CidadeIdCidade",
                table: "Hotel");

            migrationBuilder.DropColumn(
                name: "CidadeIdCidade",
                table: "Hotel");

            migrationBuilder.AddColumn<string>(
                name: "ListaHoteis",
                table: "Cidade",
                type: "TEXT",
                nullable: true);
        }
    }
}
