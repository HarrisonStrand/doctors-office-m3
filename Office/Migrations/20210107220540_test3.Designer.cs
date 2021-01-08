﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Office.Models;

namespace Office.Migrations
{
    [DbContext(typeof(OfficeContext))]
    [Migration("20210107220540_test3")]
    partial class test3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Office.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DoctorName");

                    b.Property<string>("DoctorSpecialty");

                    b.HasKey("DoctorId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("Office.Models.DoctorPatientSpecialty", b =>
                {
                    b.Property<int>("DoctorPatientSpecialtyId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DoctorId");

                    b.Property<int>("PatientId");

                    b.Property<int>("SpecialtyId");

                    b.HasKey("DoctorPatientSpecialtyId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.HasIndex("SpecialtyId");

                    b.ToTable("DoctorPatientSpecialties");
                });

            modelBuilder.Entity("Office.Models.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DOB");

                    b.Property<string>("PatientName");

                    b.HasKey("PatientId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("Office.Models.Specialty", b =>
                {
                    b.Property<int>("SpecialtyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("SpecialtyName");

                    b.HasKey("SpecialtyId");

                    b.ToTable("Specialties");
                });

            modelBuilder.Entity("Office.Models.DoctorPatientSpecialty", b =>
                {
                    b.HasOne("Office.Models.Doctor", "Doctor")
                        .WithMany("TableConnection")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Office.Models.Patient", "Patient")
                        .WithMany("TableConnection")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Office.Models.Specialty", "Specialty")
                        .WithMany("TableConnection")
                        .HasForeignKey("SpecialtyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}