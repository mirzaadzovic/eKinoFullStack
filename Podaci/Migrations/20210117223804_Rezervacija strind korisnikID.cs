using Microsoft.EntityFrameworkCore.Migrations;

namespace Podaci.Migrations
{
    public partial class RezervacijastrindkorisnikID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezervacija_AspNetUsers_KorisnikId",
                table: "Rezervacija");

            migrationBuilder.DropColumn(
                name: "KorisnikID",
                table: "Rezervacija");

            migrationBuilder.RenameColumn(
                name: "KorisnikId",
                table: "Rezervacija",
                newName: "KorisnikID");

            migrationBuilder.RenameIndex(
                name: "IX_Rezervacija_KorisnikId",
                table: "Rezervacija",
                newName: "IX_Rezervacija_KorisnikID");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervacija_AspNetUsers_KorisnikID",
                table: "Rezervacija",
                column: "KorisnikID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezervacija_AspNetUsers_KorisnikID",
                table: "Rezervacija");

            migrationBuilder.RenameColumn(
                name: "KorisnikID",
                table: "Rezervacija",
                newName: "KorisnikId");

            migrationBuilder.RenameIndex(
                name: "IX_Rezervacija_KorisnikID",
                table: "Rezervacija",
                newName: "IX_Rezervacija_KorisnikId");

            migrationBuilder.AddColumn<int>(
                name: "KorisnikID",
                table: "Rezervacija",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervacija_AspNetUsers_KorisnikId",
                table: "Rezervacija",
                column: "KorisnikId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
