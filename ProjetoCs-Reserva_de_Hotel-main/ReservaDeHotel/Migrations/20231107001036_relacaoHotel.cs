using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReservaDeHotel.Migrations
{
    /// <inheritdoc />
    public partial class relacaoHotel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Avaliacao_Hotel_HotelId",
                table: "Avaliacao");

            migrationBuilder.DropIndex(
                name: "IX_Avaliacao_HotelId",
                table: "Avaliacao");

            migrationBuilder.DropColumn(
                name: "IdDoDono",
                table: "Hotel");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAvaliacao",
                table: "Avaliacao",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "AvaliacaoEstrelas",
                table: "Avaliacao",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateTable(
                name: "AvaliacaoHotel",
                columns: table => new
                {
                    HoteisIDHotel = table.Column<int>(type: "INTEGER", nullable: false),
                    ListaAvaliacoesIdAvaliacao = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvaliacaoHotel", x => new { x.HoteisIDHotel, x.ListaAvaliacoesIdAvaliacao });
                    table.ForeignKey(
                        name: "FK_AvaliacaoHotel_Avaliacao_ListaAvaliacoesIdAvaliacao",
                        column: x => x.ListaAvaliacoesIdAvaliacao,
                        principalTable: "Avaliacao",
                        principalColumn: "IdAvaliacao",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AvaliacaoHotel_Hotel_HoteisIDHotel",
                        column: x => x.HoteisIDHotel,
                        principalTable: "Hotel",
                        principalColumn: "IDHotel",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AvaliacaoHotel_ListaAvaliacoesIdAvaliacao",
                table: "AvaliacaoHotel",
                column: "ListaAvaliacoesIdAvaliacao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AvaliacaoHotel");

            migrationBuilder.AddColumn<int>(
                name: "IdDoDono",
                table: "Hotel",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAvaliacao",
                table: "Avaliacao",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AvaliacaoEstrelas",
                table: "Avaliacao",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacao_HotelId",
                table: "Avaliacao",
                column: "HotelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Avaliacao_Hotel_HotelId",
                table: "Avaliacao",
                column: "HotelId",
                principalTable: "Hotel",
                principalColumn: "IDHotel");
        }
    }
}
