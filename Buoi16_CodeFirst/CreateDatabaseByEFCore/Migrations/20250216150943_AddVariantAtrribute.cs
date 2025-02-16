using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CreateDatabaseByEFCore.Migrations
{
    /// <inheritdoc />
    public partial class AddVariantAtrribute : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VariantAttribute",
                columns: table => new
                {
                    AttributeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VariantID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VariantAttribute", x => new { x.AttributeID, x.VariantID });
                    table.ForeignKey(
                        name: "FK_VariantAttribute_Attributes_AttributeID",
                        column: x => x.AttributeID,
                        principalTable: "Attributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VariantAttribute_Variants_VariantID",
                        column: x => x.VariantID,
                        principalTable: "Variants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VariantAttribute_VariantID",
                table: "VariantAttribute",
                column: "VariantID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VariantAttribute");
        }
    }
}
