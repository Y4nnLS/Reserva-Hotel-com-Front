using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReservaDeHotel.Migrations
{
    /// <inheritdoc />
    public partial class relacaoComodidade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IDHotel",
                table: "Comodidade");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecoPorNoite",
                table: "Comodidade",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "NumeroDoQuarto",
                table: "Comodidade",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<bool>(
                name: "Disponibilidade",
                table: "Comodidade",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "HotelId",
                table: "Comodidade",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comodidade_HotelId",
                table: "Comodidade",
                column: "HotelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comodidade_Hotel_HotelId",
                table: "Comodidade",
                column: "HotelId",
                principalTable: "Hotel",
                principalColumn: "IDHotel");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comodidade_Hotel_HotelId",
                table: "Comodidade");

            migrationBuilder.DropIndex(
                name: "IX_Comodidade_HotelId",
                table: "Comodidade");

            migrationBuilder.DropColumn(
                name: "HotelId",
                table: "Comodidade");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecoPorNoite",
                table: "Comodidade",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NumeroDoQuarto",
                table: "Comodidade",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Disponibilidade",
                table: "Comodidade",
                type: "INTEGER",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IDHotel",
                table: "Comodidade",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
