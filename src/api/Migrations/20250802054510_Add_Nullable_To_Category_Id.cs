using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class Add_Nullable_To_Category_Id : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_products_tbl_categories_category_id",
                table: "tbl_products");

            migrationBuilder.AlterColumn<Guid>(
                name: "category_id",
                table: "tbl_products",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_products_tbl_categories_category_id",
                table: "tbl_products",
                column: "category_id",
                principalTable: "tbl_categories",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_products_tbl_categories_category_id",
                table: "tbl_products");

            migrationBuilder.AlterColumn<Guid>(
                name: "category_id",
                table: "tbl_products",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_products_tbl_categories_category_id",
                table: "tbl_products",
                column: "category_id",
                principalTable: "tbl_categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
