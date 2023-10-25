using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReservaDeHotel.Migrations
{
    /// <inheritdoc />
    public partial class b : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Valor",
                table: "Pagamento",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "REAL");

            migrationBuilder.CreateTable(
                name: "Hotel",
                columns: table => new
                {
                    IDHotel = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Endereco = table.Column<string>(type: "TEXT", nullable: true),
                    Classificacao = table.Column<int>(type: "INTEGER", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: true),
                    AvaliacaoMedia = table.Column<double>(type: "REAL", nullable: false),
                    IdDoDono = table.Column<int>(type: "INTEGER", nullable: false),
                    NumeroTotalDeQuartos = table.Column<int>(type: "INTEGER", nullable: false),
                    NumeroDeQuartosDisponiveis = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotel", x => x.IDHotel);
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
                    IDHotel = table.Column<int>(type: "INTEGER", nullable: false),
                    HotelIDHotel = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comodidade", x => x.IDComodidade);
                    table.ForeignKey(
                        name: "FK_Comodidade_Hotel_HotelIDHotel",
                        column: x => x.HotelIDHotel,
                        principalTable: "Hotel",
                        principalColumn: "IDHotel");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comodidade_HotelIDHotel",
                table: "Comodidade",
                column: "HotelIDHotel");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comodidade");

            migrationBuilder.DropTable(
                name: "Hotel");

            migrationBuilder.AlterColumn<float>(
                name: "Valor",
                table: "Pagamento",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");
        }
    }
}
