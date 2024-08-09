﻿// <auto-generated />
using System;
using LibreriaSupportFast.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibreriaSupportFast.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
<<<<<<<< HEAD:LibreriaSupportFast/Migrations/20240808085542_SupportFast.Designer.cs
    [Migration("20240808085542_SupportFast")]
    partial class SupportFast
========
    [Migration("20240808090128_init")]
    partial class init
>>>>>>>> 0ca240120a83ba4e38b370f39b79d8d224ea193b:LibreriaSupportFast/Migrations/20240808090128_init.Designer.cs
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LibreriaSupportFast.Models.Areas", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("c_Area")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Areas");
                });

            modelBuilder.Entity("LibreriaSupportFast.Models.Categorias", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("c_Categoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id_TecnicoDefault")
                        .HasColumnType("int");

                    b.Property<int>("tecnicosid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("tecnicosid");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("LibreriaSupportFast.Models.Ciudades", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("c_Ciudad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Ciudades");
                });

            modelBuilder.Entity("LibreriaSupportFast.Models.Estados", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("c_Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("LibreriaSupportFast.Models.Gestiones", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("categoriasid")
                        .HasColumnType("int");

                    b.Property<int>("estadosid")
                        .HasColumnType("int");

                    b.Property<DateTime>("f_fecha_cierre")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("f_fecha_creacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("id_Ticket")
                        .HasColumnType("int");

                    b.Property<int>("id_categoria")
                        .HasColumnType("int");

                    b.Property<int>("id_estado")
                        .HasColumnType("int");

                    b.Property<int>("id_solucion")
                        .HasColumnType("int");

                    b.Property<int>("id_subcategoria")
                        .HasColumnType("int");

                    b.Property<int>("id_tecnico_asignado")
                        .HasColumnType("int");

                    b.Property<int>("solucionesid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("categoriasid");

                    b.HasIndex("estadosid");

                    b.HasIndex("solucionesid");

                    b.ToTable("Gestiones");
                });

            modelBuilder.Entity("LibreriaSupportFast.Models.Perfiles", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("c_Perfil")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Perfiles");
                });

            modelBuilder.Entity("LibreriaSupportFast.Models.Soluciones", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("c_Solucion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("l_solucion_definitiva")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.ToTable("Soluciones");
                });

            modelBuilder.Entity("LibreriaSupportFast.Models.SubCategorias", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("c_SubCategoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("categoriasid")
                        .HasColumnType("int");

                    b.Property<int>("id_Categoria")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("categoriasid");

                    b.ToTable("SubCategorias");
                });

            modelBuilder.Entity("LibreriaSupportFast.Models.Tecnicos", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("c_Tecnico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Tecnicos");
                });

            modelBuilder.Entity("LibreriaSupportFast.Models.Tickets", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("c_Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("categoriasid")
                        .HasColumnType("int");

                    b.Property<int>("estadosid")
                        .HasColumnType("int");

                    b.Property<DateTime>("f_fecha_Ultima_Gestion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("f_fecha_cierre")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("f_fecha_creacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("id_SubCategoria")
                        .HasColumnType("int");

                    b.Property<int>("id_categoria")
                        .HasColumnType("int");

                    b.Property<int>("id_estado")
                        .HasColumnType("int");

                    b.Property<int>("id_solucion")
                        .HasColumnType("int");

                    b.Property<int>("id_tecnico_asignado")
                        .HasColumnType("int");

                    b.Property<int>("solucionesid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("categoriasid");

                    b.HasIndex("estadosid");

                    b.HasIndex("solucionesid");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("LibreriaSupportFast.Models.Usuarios", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("areasid")
                        .HasColumnType("int");

                    b.Property<string>("c_Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c_Cedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c_Direccione")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("c_Nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ciudadesid")
                        .HasColumnType("int");

                    b.Property<DateTime>("f_FecNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("f_FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("f_FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("id_Area")
                        .HasColumnType("int");

                    b.Property<int>("id_Ciudad")
                        .HasColumnType("int");

                    b.Property<int>("id_CodPerfil")
                        .HasColumnType("int");

                    b.Property<int>("perfilesid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("areasid");

                    b.HasIndex("ciudadesid");

                    b.HasIndex("perfilesid");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("LibreriaSupportFast.Models.Categorias", b =>
                {
                    b.HasOne("LibreriaSupportFast.Models.Tecnicos", "tecnicos")
                        .WithMany()
                        .HasForeignKey("tecnicosid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("tecnicos");
                });

            modelBuilder.Entity("LibreriaSupportFast.Models.Gestiones", b =>
                {
                    b.HasOne("LibreriaSupportFast.Models.Categorias", "categorias")
                        .WithMany()
                        .HasForeignKey("categoriasid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibreriaSupportFast.Models.Estados", "estados")
                        .WithMany()
                        .HasForeignKey("estadosid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibreriaSupportFast.Models.Soluciones", "soluciones")
                        .WithMany()
                        .HasForeignKey("solucionesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("categorias");

                    b.Navigation("estados");

                    b.Navigation("soluciones");
                });

            modelBuilder.Entity("LibreriaSupportFast.Models.SubCategorias", b =>
                {
                    b.HasOne("LibreriaSupportFast.Models.Categorias", "categorias")
                        .WithMany()
                        .HasForeignKey("categoriasid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("categorias");
                });

            modelBuilder.Entity("LibreriaSupportFast.Models.Tickets", b =>
                {
                    b.HasOne("LibreriaSupportFast.Models.Categorias", "categorias")
                        .WithMany()
                        .HasForeignKey("categoriasid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibreriaSupportFast.Models.Estados", "estados")
                        .WithMany()
                        .HasForeignKey("estadosid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibreriaSupportFast.Models.Soluciones", "soluciones")
                        .WithMany()
                        .HasForeignKey("solucionesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("categorias");

                    b.Navigation("estados");

                    b.Navigation("soluciones");
                });

            modelBuilder.Entity("LibreriaSupportFast.Models.Usuarios", b =>
                {
                    b.HasOne("LibreriaSupportFast.Models.Areas", "areas")
                        .WithMany()
                        .HasForeignKey("areasid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibreriaSupportFast.Models.Ciudades", "ciudades")
                        .WithMany()
                        .HasForeignKey("ciudadesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibreriaSupportFast.Models.Perfiles", "perfiles")
                        .WithMany()
                        .HasForeignKey("perfilesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("areas");

                    b.Navigation("ciudades");

                    b.Navigation("perfiles");
                });
#pragma warning restore 612, 618
        }
    }
}
