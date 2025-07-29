using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class Add_More_Fields_To_User : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "role",
                table: "tbl_users",
                type: "text",
                nullable: false,
                defaultValue: "user");
            migrationBuilder.AddColumn<DateTime>(
                name: "email_verified_at",
                table: "tbl_users",
                type: "timestamp with time zone",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "role",
                table: "tbl_users");
            migrationBuilder.DropColumn(
                name: "email_verified_at",
                table: "tbl_users");
        }
    }
}
