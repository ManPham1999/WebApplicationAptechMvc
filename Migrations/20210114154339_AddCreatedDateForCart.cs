using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AptechMVCProject.Migrations
{
    public partial class AddCreatedDateForCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "CartLines",
                newName: "Id");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Carts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Carts");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CartLines",
                newName: "ID");
        }
    }
}
