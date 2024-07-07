﻿// <auto-generated />
using System;
using InterviewTask.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InterviewTask.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InterviewTask.Models.InvoiceDetails", b =>
                {
                    b.Property<int>("lineNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("lineNo"));

                    b.Property<DateTime>("expiryDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<string>("productName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("total")
                        .HasColumnType("int");

                    b.Property<int>("unitNo")
                        .HasColumnType("int");

                    b.HasKey("lineNo");

                    b.ToTable("invoiceDetails");
                });

            modelBuilder.Entity("InterviewTask.Models.Unit", b =>
                {
                    b.Property<int>("unitNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("unitNo"));

                    b.Property<string>("unitName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("unitNo");

                    b.ToTable("Units");
                });
#pragma warning restore 612, 618
        }
    }
}
