﻿// <auto-generated />
using System;
using AsistenciaSport.BD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AsistenciaSport.BD.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240924053829_TablaCuota")]
    partial class TablaCuota
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AsistenciaSport.BD.Data.Entity.Administrador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaRegistro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Administradores");
                });

            modelBuilder.Entity("AsistenciaSport.BD.Data.Entity.Asistencias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Egreso")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdMiembro")
                        .HasColumnType("int");

                    b.Property<DateTime>("Ingreso")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Asistencia");
                });

            modelBuilder.Entity("AsistenciaSport.BD.Data.Entity.Cuotas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Fecha")
                        .HasColumnType("int");

                    b.Property<int>("IdAdministrador")
                        .HasColumnType("int");

                    b.Property<int>("IdMiembro")
                        .HasColumnType("int");

                    b.Property<int>("Monto")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cuotas");
                });

            modelBuilder.Entity("AsistenciaSport.BD.Data.Entity.Miembro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Fecha")
                        .HasColumnType("int");

                    b.Property<int>("IdAdministrador")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Miembros");
                });
#pragma warning restore 612, 618
        }
    }
}
