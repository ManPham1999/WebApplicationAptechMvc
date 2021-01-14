using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AptechMVCProject.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartTypes", x => x.Id);
                });

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
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Gender = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserRefId = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: true),
                    CardTypeRefId = table.Column<string>(nullable: true),
                    CardTypeId = table.Column<Guid>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_CartTypes_CardTypeId",
                        column: x => x.CardTypeId,
                        principalTable: "CartTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Carts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CartLines",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CartRefId = table.Column<string>(nullable: true),
                    CartId = table.Column<Guid>(nullable: true),
                    ProductId = table.Column<Guid>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartLines", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CartLines_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CartLines_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartLines_CartId",
                table: "CartLines",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartLines_ProductId",
                table: "CartLines",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_CardTypeId",
                table: "Carts",
                column: "CardTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CatgoryCatId",
                table: "Products",
                column: "CatgoryCatId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartLines");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "CartTypes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Catgories");
        }
    }
}
