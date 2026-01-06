using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaCs.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixingServices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Accounts_AccountNumber",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "MenuItems");

            migrationBuilder.DropIndex(
                name: "IX_Users_AccountNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AccountNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserEmail",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AccountNumber",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "UserEmail",
                table: "Users",
                type: "nvarchar(254)",
                maxLength: 254,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    ObjectKey = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountNumber = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.ObjectKey);
                });

            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    ObjectKey = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Available = table.Column<bool>(type: "bit", nullable: false),
                    MenuItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuItemName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<double>(type: "float", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.ObjectKey);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    ObjectKey = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuItemEfcObjectKey = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.ObjectKey);
                    table.ForeignKey(
                        name: "FK_Ingredients_MenuItems_MenuItemEfcObjectKey",
                        column: x => x.MenuItemEfcObjectKey,
                        principalTable: "MenuItems",
                        principalColumn: "ObjectKey");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_AccountNumber",
                table: "Users",
                column: "AccountNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_AccountNumber",
                table: "Accounts",
                column: "AccountNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_MenuItemEfcObjectKey",
                table: "Ingredients",
                column: "MenuItemEfcObjectKey");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Accounts_AccountNumber",
                table: "Users",
                column: "AccountNumber",
                principalTable: "Accounts",
                principalColumn: "ObjectKey",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
