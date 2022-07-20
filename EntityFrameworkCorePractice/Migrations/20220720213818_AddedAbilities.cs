using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkCorePractice.Migrations
{
    public partial class AddedAbilities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ability",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ability",
                table: "Animals");
        }
    }
}
