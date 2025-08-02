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
            migrationBuilder.RenameColumn(
                name: "name",
                table: "tbl_users",
                newName: "username");
            migrationBuilder.AddColumn<int>(
                name: "role",
                table: "tbl_users",
                type: "int",
                nullable: false,
                defaultValue: 1);
            migrationBuilder.AddColumn<DateTime>(
                name: "email_verified_at",
                table: "tbl_users",
                type: "timestamp with time zone",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "username",
                table: "tbl_users",
                newName: "name");
            migrationBuilder.DropColumn(
                name: "role",
                table: "tbl_users");
            migrationBuilder.DropColumn(
                name: "email_verified_at",
                table: "tbl_users");
        }
    }
}
