using Microsoft.EntityFrameworkCore.Migrations;

namespace Office.Migrations
{
    public partial class test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DoctorSpecialty",
                table: "Doctors");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DoctorSpecialty",
                table: "Doctors",
                nullable: true);
        }
    }
}
