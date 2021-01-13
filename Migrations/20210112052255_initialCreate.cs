using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AptechMVCProject.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catgories",
                columns: table => new
                {
                    CatId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catgories", x => x.CatId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Quantity = table.Column<double>(nullable: false),
                    Img = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true),
                    CatgoryRefId = table.Column<string>(nullable: true),
                    CatgoryCatId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Catgories_CatgoryCatId",
                        column: x => x.CatgoryCatId,
                        principalTable: "Catgories",
                        principalColumn: "CatId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CatgoryCatId",
                table: "Products",
                column: "CatgoryCatId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Catgories");
        }
    }
}
