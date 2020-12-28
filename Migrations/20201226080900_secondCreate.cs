using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AptechMVCProject.Migrations
{
    public partial class secondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catgories",
                columns: table => new
                {
                    CatId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    IsSelected = table.Column<bool>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    CoffeeRefId = table.Column<Guid>(nullable: false),
                    CoffeeId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catgories", x => x.CatId);
                    table.ForeignKey(
                        name: "FK_Catgories_Products_CoffeeId",
                        column: x => x.CoffeeId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Catgories_CoffeeId",
                table: "Catgories",
                column: "CoffeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Catgories");
        }
    }
}
