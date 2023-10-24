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
            migrationBuilder.DropForeignKey(
                name: "FK_Hotel_Dono_DonoId",
                table: "Hotel");

            migrationBuilder.DropIndex(
                name: "IX_Hotel_DonoId",
                table: "Hotel");

            migrationBuilder.DropColumn(
                name: "DonoId",
                table: "Hotel");

            migrationBuilder.RenameColumn(
                name: "IdDoDono",
                table: "Hotel",
                newName: "IdDono");

            migrationBuilder.AddColumn<int>(
                name: "HotelIDHotel",
                table: "Dono",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_IdDono",
                table: "Hotel",
                column: "IdDono");

            migrationBuilder.CreateIndex(
                name: "IX_Dono_HotelIDHotel",
                table: "Dono",
                column: "HotelIDHotel");

            migrationBuilder.AddForeignKey(
                name: "FK_Dono_Hotel_HotelIDHotel",
                table: "Dono",
                column: "HotelIDHotel",
                principalTable: "Hotel",
                principalColumn: "IDHotel",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hotel_Dono_IdDono",
                table: "Hotel",
                column: "IdDono",
                principalTable: "Dono",
                principalColumn: "DonoId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dono_Hotel_HotelIDHotel",
                table: "Dono");

            migrationBuilder.DropForeignKey(
                name: "FK_Hotel_Dono_IdDono",
                table: "Hotel");

            migrationBuilder.DropIndex(
                name: "IX_Hotel_IdDono",
                table: "Hotel");

            migrationBuilder.DropIndex(
                name: "IX_Dono_HotelIDHotel",
                table: "Dono");

            migrationBuilder.DropColumn(
                name: "HotelIDHotel",
                table: "Dono");

            migrationBuilder.RenameColumn(
                name: "IdDono",
                table: "Hotel",
                newName: "IdDoDono");

            migrationBuilder.AddColumn<int>(
                name: "DonoId",
                table: "Hotel",
                type: "INTEGER",
                nullable: true);

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
    }
}
