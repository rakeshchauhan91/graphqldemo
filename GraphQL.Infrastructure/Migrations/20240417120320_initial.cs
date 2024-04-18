using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GraphQL.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_Owners_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[,]
                {
                    { new Guid("4c004851-1720-4fff-8c0c-ce7863292e9d"), "John Doe's address", "John Doe" },
                    { new Guid("d728a4f4-665f-4fa8-97b0-3d6141c98642"), "Jane Doe's address", "Jane Doe" }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Description", "OwnerId", "Type" },
                values: new object[,]
                {
                    { new Guid("81b2d133-9c69-49f6-87ff-2973d3ca737f"), "Savings account for our users", new Guid("d728a4f4-665f-4fa8-97b0-3d6141c98642"), 1 },
                    { new Guid("a82aa302-e2c0-4a73-a185-2eb2163c60b8"), "Income account for our users", new Guid("d728a4f4-665f-4fa8-97b0-3d6141c98642"), 3 },
                    { new Guid("e444aaf8-b4cc-43f3-9113-e13dd4c93b5f"), "Cash account for our users", new Guid("4c004851-1720-4fff-8c0c-ce7863292e9d"), 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_OwnerId",
                table: "Accounts",
                column: "OwnerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Owners");
        }
    }
}
