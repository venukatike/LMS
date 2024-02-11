﻿// <auto-generated />
using System;
using LabManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LabManagementSystem.Migrations
{
    [DbContext(typeof(LabManagementSystemContext))]
    [Migration("20240206123638_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LabManagementSystem.Models.LabReport", b =>
                {
                    b.Property<int>("ReportID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReportID"), 1L, 1);

                    b.Property<DateTime>("EnteredTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Results")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeofTest")
                        .HasColumnType("datetime2");

                    b.HasKey("ReportID");

                    b.ToTable("labReports");
                });

            modelBuilder.Entity("LabManagementSystem.Models.Patient", b =>
                {
                    b.Property<int>("PatientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PatientID"), 1L, 1);

                    b.Property<string>("PatientAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientAge")
                        .HasColumnType("int");

                    b.Property<DateTime>("PatientDOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("PatientGender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatientName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PatientID");

                    b.ToTable("patients");
                });
#pragma warning restore 612, 618
        }
    }
}
