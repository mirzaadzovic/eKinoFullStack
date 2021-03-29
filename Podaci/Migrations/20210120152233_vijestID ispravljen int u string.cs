using Microsoft.EntityFrameworkCore.Migrations;

namespace Podaci.Migrations
{
    public partial class vijestIDispravljenintustring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vijest_AspNetUsers_KorisnikId",
                table: "Vijest");

            migrationBuilder.DropColumn(
                name: "KorisnikID",
                table: "Vijest");

            migrationBuilder.RenameColumn(
                name: "KorisnikId",
                table: "Vijest",
                newName: "KorisnikID");

            migrationBuilder.RenameIndex(
                name: "IX_Vijest_KorisnikId",
                table: "Vijest",
                newName: "IX_Vijest_KorisnikID");

            migrationBuilder.AddForeignKey(
                name: "FK_Vijest_AspNetUsers_KorisnikID",
                table: "Vijest",
                column: "KorisnikID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vijest_AspNetUsers_KorisnikID",
                table: "Vijest");

            migrationBuilder.RenameColumn(
                name: "KorisnikID",
                table: "Vijest",
                newName: "KorisnikId");

            migrationBuilder.RenameIndex(
                name: "IX_Vijest_KorisnikID",
                table: "Vijest",
                newName: "IX_Vijest_KorisnikId");

            migrationBuilder.AddColumn<int>(
                name: "KorisnikID",
                table: "Vijest",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Vijest_AspNetUsers_KorisnikId",
                table: "Vijest",
                column: "KorisnikId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
