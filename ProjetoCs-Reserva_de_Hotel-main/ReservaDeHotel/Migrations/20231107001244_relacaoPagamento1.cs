using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReservaDeHotel.Migrations
{
    /// <inheritdoc />
    public partial class relacaoPagamento1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagamento_Pagamento_PagamentoIdPagamento",
                table: "Pagamento");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagamento_ReservaHotel_ReservaIdReserva",
                table: "Pagamento");

            migrationBuilder.DropIndex(
                name: "IX_Pagamento_PagamentoIdPagamento",
                table: "Pagamento");

            migrationBuilder.DropColumn(
                name: "PagamentoIdPagamento",
                table: "Pagamento");

            migrationBuilder.RenameColumn(
                name: "ReservaIdReserva",
                table: "Pagamento",
                newName: "ReservaId");

            migrationBuilder.RenameIndex(
                name: "IX_Pagamento_ReservaIdReserva",
                table: "Pagamento",
                newName: "IX_Pagamento_ReservaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamento_ReservaHotel_ReservaId",
                table: "Pagamento",
                column: "ReservaId",
                principalTable: "ReservaHotel",
                principalColumn: "IdReserva");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagamento_ReservaHotel_ReservaId",
                table: "Pagamento");

            migrationBuilder.RenameColumn(
                name: "ReservaId",
                table: "Pagamento",
                newName: "ReservaIdReserva");

            migrationBuilder.RenameIndex(
                name: "IX_Pagamento_ReservaId",
                table: "Pagamento",
                newName: "IX_Pagamento_ReservaIdReserva");

            migrationBuilder.AddColumn<int>(
                name: "PagamentoIdPagamento",
                table: "Pagamento",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pagamento_PagamentoIdPagamento",
                table: "Pagamento",
                column: "PagamentoIdPagamento");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamento_Pagamento_PagamentoIdPagamento",
                table: "Pagamento",
                column: "PagamentoIdPagamento",
                principalTable: "Pagamento",
                principalColumn: "IdPagamento");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamento_ReservaHotel_ReservaIdReserva",
                table: "Pagamento",
                column: "ReservaIdReserva",
                principalTable: "ReservaHotel",
                principalColumn: "IdReserva");
        }
    }
}
