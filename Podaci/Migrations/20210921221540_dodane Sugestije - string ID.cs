using Microsoft.EntityFrameworkCore.Migrations;

namespace Podaci.Migrations
{
    public partial class dodaneSugestijestringID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sugestija_AspNetUsers_KorisnikId",
                table: "Sugestija");

            migrationBuilder.DropColumn(
                name: "KorisnikID",
                table: "Sugestija");

            migrationBuilder.RenameColumn(
                name: "KorisnikId",
                table: "Sugestija",
                newName: "KorisnikID");

            migrationBuilder.RenameIndex(
                name: "IX_Sugestija_KorisnikId",
                table: "Sugestija",
                newName: "IX_Sugestija_KorisnikID");

            migrationBuilder.AddForeignKey(
                name: "FK_Sugestija_AspNetUsers_KorisnikID",
                table: "Sugestija",
                column: "KorisnikID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sugestija_AspNetUsers_KorisnikID",
                table: "Sugestija");

            migrationBuilder.RenameColumn(
                name: "KorisnikID",
                table: "Sugestija",
                newName: "KorisnikId");

            migrationBuilder.RenameIndex(
                name: "IX_Sugestija_KorisnikID",
                table: "Sugestija",
                newName: "IX_Sugestija_KorisnikId");

            migrationBuilder.AddColumn<int>(
                name: "KorisnikID",
                table: "Sugestija",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Sugestija_AspNetUsers_KorisnikId",
                table: "Sugestija",
                column: "KorisnikId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
