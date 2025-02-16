using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CreateDatabaseByEFCore.Migrations
{
    /// <inheritdoc />
    public partial class AddVariant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Variants",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    NumberInStock = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserNameCreated = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserNameUpdated = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Filter = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ExtraField1 = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ExtraField2 = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ExtraField3 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Variants_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Variants_ProductId",
                table: "Variants",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Variants");
        }
    }
}
