﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectWebAppEF.Context;

namespace ProyectWebAppEF.Migrations
{
    [DbContext(typeof(ProyectoDataContext))]
    [Migration("20190526021131_CrearDB")]
    partial class CrearDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProyectWebAppEF.Model.AplicacionTrabajo", b =>
                {
                    b.Property<int>("Idaplicacion")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Idaplicacion");

                    b.ToTable("AplicacionTrabajo","dbo");
                });

            modelBuilder.Entity("ProyectWebAppEF.Model.EducacionUsuario", b =>
                {
                    b.Property<int>("IdEducacion")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("Text");

                    b.Property<string>("DondeEstudio")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 64)))
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("FechaFinal")
                        .HasColumnType("Date");

                    b.Property<DateTime>("FechaInicio");

                    b.HasKey("IdEducacion");

                    b.ToTable("EducacionUsuario","dbo");
                });

            modelBuilder.Entity("ProyectWebAppEF.Model.Empresa", b =>
                {
                    b.Property<int>("Idempresa")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Contacto");

                    b.Property<string>("Contrasenia")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Correo")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Mision")
                        .HasColumnType("Text");

                    b.Property<string>("Nombre");

                    b.Property<string>("RTN")
                        .HasColumnType("varchar")
                        .HasMaxLength(50);

                    b.Property<string>("SobreNosotros")
                        .HasColumnType("Text");

                    b.Property<string>("Vision")
                        .HasColumnType("Text");

                    b.HasKey("Idempresa");

                    b.ToTable("Empresa","dbo");
                });

            modelBuilder.Entity("ProyectWebAppEF.Model.PublicacionTrabajo", b =>
                {
                    b.Property<int>("IdPropuesta")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("Text")
                        .HasMaxLength(500);

                    b.Property<string>("PuestoTrabajo")
                        .HasColumnType("varchar(80)")
                        .HasMaxLength(80);

                    b.HasKey("IdPropuesta");

                    b.ToTable("PublicacionTrabajo","dbo");
                });

            modelBuilder.Entity("ProyectWebAppEF.Model.Usuario", b =>
                {
                    b.Property<int>("Idusuario")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contrasenia")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Correo")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Cuidad")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Direccion")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("PrimerApellido")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("PrimerNombre")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("Telefono");

                    b.HasKey("Idusuario");

                    b.ToTable("Usuario","dbo");
                });
#pragma warning restore 612, 618
        }
    }
}