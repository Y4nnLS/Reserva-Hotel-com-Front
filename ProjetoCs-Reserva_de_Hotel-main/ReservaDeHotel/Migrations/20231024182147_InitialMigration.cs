using System;
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
            migrationBuilder.CreateTable(
                name: "Cidade",
                columns: table => new
                {
                    IdCidade = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Estado = table.Column<string>(type: "TEXT", nullable: true),
                    País = table.Column<string>(type: "TEXT", nullable: true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidade", x => x.IdCidade);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    NumeroTelefone = table.Column<int>(type: "INTEGER", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Login = table.Column<string>(type: "TEXT", nullable: true),
                    Senha = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Comodidade",
                columns: table => new
                {
                    IDComodidade = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NumeroDoQuarto = table.Column<int>(type: "INTEGER", nullable: false),
                    TipoDeQuarto = table.Column<string>(type: "TEXT", nullable: true),
                    PrecoPorNoite = table.Column<decimal>(type: "TEXT", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: true),
                    Disponibilidade = table.Column<bool>(type: "INTEGER", nullable: false),
                    IDHotel = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comodidade", x => x.IDComodidade);
                });

            migrationBuilder.CreateTable(
                name: "Dono",
                columns: table => new
                {
                    DonoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    NumeroTelefone = table.Column<int>(type: "INTEGER", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Login = table.Column<string>(type: "TEXT", nullable: true),
                    Senha = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dono", x => x.DonoId);
                });

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
                name: "Hotel",
                columns: table => new
                {
                    IDHotel = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Endereco = table.Column<string>(type: "TEXT", nullable: true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: true),
                    ListaDeQuartos = table.Column<string>(type: "TEXT", nullable: true),
                    AvaliacaoMedia = table.Column<double>(type: "REAL", nullable: false),
                    IdDoDono = table.Column<int>(type: "INTEGER", nullable: false),
                    NumeroTotalDeQuartos = table.Column<int>(type: "INTEGER", nullable: false),
                    NumeroDeQuartosDisponiveis = table.Column<int>(type: "INTEGER", nullable: false),
                    CidadeIdCidade = table.Column<int>(type: "INTEGER", nullable: true),
                    DonoId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotel", x => x.IDHotel);
                    table.ForeignKey(
                        name: "FK_Hotel_Cidade_CidadeIdCidade",
                        column: x => x.CidadeIdCidade,
                        principalTable: "Cidade",
                        principalColumn: "IdCidade");
                    table.ForeignKey(
                        name: "FK_Hotel_Dono_DonoId",
                        column: x => x.DonoId,
                        principalTable: "Dono",
                        principalColumn: "DonoId");
                });

            migrationBuilder.CreateTable(
                name: "ReservaHotel",
                columns: table => new
                {
                    IdReserva = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeHospede = table.Column<string>(type: "TEXT", nullable: true),
                    EstadiaIdEstadia = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservaHotel", x => x.IdReserva);
                    table.ForeignKey(
                        name: "FK_ReservaHotel_EstadiaHotel_EstadiaIdEstadia",
                        column: x => x.EstadiaIdEstadia,
                        principalTable: "EstadiaHotel",
                        principalColumn: "IdEstadia");
                });

            migrationBuilder.CreateTable(
                name: "Avaliacao",
                columns: table => new
                {
                    IdAvaliacao = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdHotel = table.Column<int>(type: "INTEGER", nullable: false),
                    AvaliacaoEstrelas = table.Column<int>(type: "INTEGER", nullable: false),
                    Comentario = table.Column<string>(type: "TEXT", nullable: true),
                    DataAvaliacao = table.Column<DateTime>(type: "TEXT", nullable: false),
                    HotelIDHotel = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avaliacao", x => x.IdAvaliacao);
                    table.ForeignKey(
                        name: "FK_Avaliacao_Hotel_HotelIDHotel",
                        column: x => x.HotelIDHotel,
                        principalTable: "Hotel",
                        principalColumn: "IDHotel");
                });

            migrationBuilder.CreateTable(
                name: "Pagamento",
                columns: table => new
                {
                    IdPagamento = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdReservaEstadia = table.Column<int>(type: "INTEGER", nullable: false),
                    MetodoPagamento = table.Column<string>(type: "TEXT", nullable: true),
                    Valor = table.Column<decimal>(type: "TEXT", nullable: false),
                    DataPagamento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ReservaHotelIdReserva = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagamento", x => x.IdPagamento);
                    table.ForeignKey(
                        name: "FK_Pagamento_ReservaHotel_ReservaHotelIdReserva",
                        column: x => x.ReservaHotelIdReserva,
                        principalTable: "ReservaHotel",
                        principalColumn: "IdReserva");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacao_HotelIDHotel",
                table: "Avaliacao",
                column: "HotelIDHotel");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_CidadeIdCidade",
                table: "Hotel",
                column: "CidadeIdCidade");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_DonoId",
                table: "Hotel",
                column: "DonoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagamento_ReservaHotelIdReserva",
                table: "Pagamento",
                column: "ReservaHotelIdReserva");

            migrationBuilder.CreateIndex(
                name: "IX_ReservaHotel_EstadiaIdEstadia",
                table: "ReservaHotel",
                column: "EstadiaIdEstadia");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Avaliacao");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Comodidade");

            migrationBuilder.DropTable(
                name: "Pagamento");

            migrationBuilder.DropTable(
                name: "Hotel");

            migrationBuilder.DropTable(
                name: "ReservaHotel");

            migrationBuilder.DropTable(
                name: "Cidade");

            migrationBuilder.DropTable(
                name: "Dono");

            migrationBuilder.DropTable(
                name: "EstadiaHotel");
        }
    }
}
