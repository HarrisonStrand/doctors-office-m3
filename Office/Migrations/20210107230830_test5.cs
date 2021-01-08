using Microsoft.EntityFrameworkCore.Migrations;

namespace Office.Migrations
{
    public partial class test5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoctorPatientSpecialties_Patients_PatientId",
                table: "DoctorPatientSpecialties");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorPatientSpecialties_Specialties_SpecialtyId",
                table: "DoctorPatientSpecialties");

            migrationBuilder.AlterColumn<int>(
                name: "SpecialtyId",
                table: "DoctorPatientSpecialties",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PatientId",
                table: "DoctorPatientSpecialties",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorPatientSpecialties_Patients_PatientId",
                table: "DoctorPatientSpecialties",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "PatientId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorPatientSpecialties_Specialties_SpecialtyId",
                table: "DoctorPatientSpecialties",
                column: "SpecialtyId",
                principalTable: "Specialties",
                principalColumn: "SpecialtyId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoctorPatientSpecialties_Patients_PatientId",
                table: "DoctorPatientSpecialties");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorPatientSpecialties_Specialties_SpecialtyId",
                table: "DoctorPatientSpecialties");

            migrationBuilder.AlterColumn<int>(
                name: "SpecialtyId",
                table: "DoctorPatientSpecialties",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PatientId",
                table: "DoctorPatientSpecialties",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorPatientSpecialties_Patients_PatientId",
                table: "DoctorPatientSpecialties",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "PatientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorPatientSpecialties_Specialties_SpecialtyId",
                table: "DoctorPatientSpecialties",
                column: "SpecialtyId",
                principalTable: "Specialties",
                principalColumn: "SpecialtyId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
