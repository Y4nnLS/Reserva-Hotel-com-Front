using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReservaDeHotel.Migrations
{
    /// <inheritdoc />
    public partial class relacaoDono : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotel_Cidade_CidadeIdCidade",
                table: "Hotel");

            migrationBuilder.DropForeignKey(
                name: "FK_Hotel_Dono_DonoId",
                table: "Hotel");

            migrationBuilder.DropIndex(
                name: "IX_Hotel_CidadeIdCidade",
                table: "Hotel");

            migrationBuilder.DropIndex(
                name: "IX_Hotel_DonoId",
                table: "Hotel");

            migrationBuilder.DropColumn(
                name: "CidadeIdCidade",
                table: "Hotel");

            migrationBuilder.DropColumn(
                name: "DonoId",
                table: "Hotel");

            migrationBuilder.RenameColumn(
                name: "DonoId",
                table: "Dono",
                newName: "IdDono");

            migrationBuilder.CreateTable(
                name: "CidadeHotel",
                columns: table => new
                {
                    CidadesIdCidade = table.Column<int>(type: "INTEGER", nullable: false),
                    HoteisIDHotel = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CidadeHotel", x => new { x.CidadesIdCidade, x.HoteisIDHotel });
                    table.ForeignKey(
                        name: "FK_CidadeHotel_Cidade_CidadesIdCidade",
                        column: x => x.CidadesIdCidade,
                        principalTable: "Cidade",
                        principalColumn: "IdCidade",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CidadeHotel_Hotel_HoteisIDHotel",
                        column: x => x.HoteisIDHotel,
                        principalTable: "Hotel",
                        principalColumn: "IDHotel",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DonoHotel",
                columns: table => new
                {
                    DonosIdDono = table.Column<int>(type: "INTEGER", nullable: false),
                    HoteisIDHotel = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonoHotel", x => new { x.DonosIdDono, x.HoteisIDHotel });
                    table.ForeignKey(
                        name: "FK_DonoHotel_Dono_DonosIdDono",
                        column: x => x.DonosIdDono,
                        principalTable: "Dono",
                        principalColumn: "IdDono",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonoHotel_Hotel_HoteisIDHotel",
                        column: x => x.HoteisIDHotel,
                        principalTable: "Hotel",
                        principalColumn: "IDHotel",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CidadeHotel_HoteisIDHotel",
                table: "CidadeHotel",
                column: "HoteisIDHotel");

            migrationBuilder.CreateIndex(
                name: "IX_DonoHotel_HoteisIDHotel",
                table: "DonoHotel",
                column: "HoteisIDHotel");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CidadeHotel");

            migrationBuilder.DropTable(
                name: "DonoHotel");

            migrationBuilder.RenameColumn(
                name: "IdDono",
                table: "Dono",
                newName: "DonoId");

            migrationBuilder.AddColumn<int>(
                name: "CidadeIdCidade",
                table: "Hotel",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DonoId",
                table: "Hotel",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_CidadeIdCidade",
                table: "Hotel",
                column: "CidadeIdCidade");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_DonoId",
                table: "Hotel",
                column: "DonoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotel_Cidade_CidadeIdCidade",
                table: "Hotel",
                column: "CidadeIdCidade",
                principalTable: "Cidade",
                principalColumn: "IdCidade");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotel_Dono_DonoId",
                table: "Hotel",
                column: "DonoId",
                principalTable: "Dono",
                principalColumn: "DonoId");
        }
    }
}
