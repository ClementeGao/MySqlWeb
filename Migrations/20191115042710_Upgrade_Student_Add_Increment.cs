using Microsoft.EntityFrameworkCore.Migrations;

namespace MySql.Web.Migrations
{
    public partial class Upgrade_Student_Add_Increment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IsTest",
                table: "Students",
                nullable: false,
                oldClrType: typeof(short));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "IsTest",
                table: "Students",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
