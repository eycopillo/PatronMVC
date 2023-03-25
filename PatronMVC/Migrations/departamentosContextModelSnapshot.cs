﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PatronMVC.Models;

#nullable disable

namespace PatronMVC.Migrations
{
    [DbContext(typeof(departamentosContext))]
    partial class departamentosContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PatronMVC.Models.Departamentos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Baño")
                        .HasColumnType("int");

                    b.Property<int>("Habitaciones")
                        .HasColumnType("int");

                    b.Property<string>("Ubicacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("costo")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Departamentos");
                });
#pragma warning restore 612, 618
        }
    }
}