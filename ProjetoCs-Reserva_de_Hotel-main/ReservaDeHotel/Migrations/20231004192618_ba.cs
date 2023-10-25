using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReservaDeHotel.Migrations
{
    /// <inheritdoc />
    public partial class ba : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DonoId",
                table: "Hotel",
                type: "INTEGER",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_DonoId",
                table: "Hotel",
                column: "DonoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotel_Dono_DonoId",
                table: "Hotel",
                column: "DonoId",
                principalTable: "Dono",
                principalColumn: "DonoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotel_Dono_DonoId",
                table: "Hotel");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Dono");

            migrationBuilder.DropIndex(
                name: "IX_Hotel_DonoId",
                table: "Hotel");

            migrationBuilder.DropColumn(
                name: "DonoId",
                table: "Hotel");
        }
    }
}
