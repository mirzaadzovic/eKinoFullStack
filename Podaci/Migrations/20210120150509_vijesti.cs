using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Podaci.Migrations
{
    public partial class vijesti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vijest",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naslov = table.Column<string>(nullable: true),
                    Sadrzaj = table.Column<string>(nullable: true),
                    SlikaUrl = table.Column<string>(nullable: true),
                    Datum = table.Column<DateTime>(nullable: false),
                    KorisnikID = table.Column<int>(nullable: false),
                    KorisnikId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vijest", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Vijest_AspNetUsers_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vijest_KorisnikId",
                table: "Vijest",
                column: "KorisnikId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vijest");
        }
    }
}
