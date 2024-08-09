﻿// <auto-generated />
using System;
using LibreriaSupportFast.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibreriaSupportFast.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LibreriaSupportFast.Models.Areas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("C_Area")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Areas");
                });

            modelBuilder.Entity("LibreriaSupportFast.Models.Categorias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("C_Categoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_TecnicoDefault")
                        .HasColumnType("int");

                    b.Property<int?>("TecnicosId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TecnicosId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("LibreriaSupportFast.Models.Ciudades", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("C_Ciudad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ciudades");
                });

            modelBuilder.Entity("LibreriaSupportFast.Models.Estados", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("C_Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("LibreriaSupportFast.Models.Gestiones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoriasId")
                        .HasColumnType("int");

                    b.Property<int?>("EstadosId")
                        .HasColumnType("int");

                    b.Property<DateTime>("F_fecha_cierre")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("F_fecha_creacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Ticket")
                        .HasColumnType("int");

                    b.Property<int>("Id_categoria")
                        .HasColumnType("int");

                    b.Property<int>("Id_estado")
                        .HasColumnType("int");

                    b.Property<int>("Id_solucion")
                        .HasColumnType("int");

                    b.Property<int>("Id_subcategoria")
                        .HasColumnType("int");

                    b.Property<int>("Id_tecnico_asignado")
                        .HasColumnType("int");

                    b.Property<int?>("SolucionesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoriasId");

                    b.HasIndex("EstadosId");

                    b.HasIndex("SolucionesId");

                    b.ToTable("Gestiones");
                });

            modelBuilder.Entity("LibreriaSupportFast.Models.Perfiles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("C_Perfil")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Perfiles");
                });

            modelBuilder.Entity("LibreriaSupportFast.Models.Soluciones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("C_Solucion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("L_solucion_definitiva")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Soluciones");
                });

            modelBuilder.Entity("LibreriaSupportFast.Models.SubCategorias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("C_SubCategoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CategoriasId")
                        .HasColumnType("int");

                    b.Property<int>("Id_Categoria")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoriasId");

                    b.ToTable("SubCategorias");
                });

            modelBuilder.Entity("LibreriaSupportFast.Models.Tecnicos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("C_Tecnico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tecnicos");
                });

            modelBuilder.Entity("LibreriaSupportFast.Models.Tickets", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("C_Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CategoriasId")
                        .HasColumnType("int");

                    b.Property<int?>("EstadosId")
                        .HasColumnType("int");

                    b.Property<DateTime>("F_fecha_Ultima_Gestion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("F_fecha_cierre")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("F_fecha_creacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_SubCategoria")
                        .HasColumnType("int");

                    b.Property<int>("Id_categoria")
                        .HasColumnType("int");

                    b.Property<int>("Id_estado")
                        .HasColumnType("int");

                    b.Property<int>("Id_solucion")
                        .HasColumnType("int");

                    b.Property<int>("Id_tecnico_asignado")
                        .HasColumnType("int");

                    b.Property<int?>("SolucionesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoriasId");

                    b.HasIndex("EstadosId");

                    b.HasIndex("SolucionesId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("LibreriaSupportFast.Models.Usuarios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AreasId")
                        .HasColumnType("int");

                    b.Property<string>("C_Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C_Cedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C_Direcciones")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C_Nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CiudadesId")
                        .HasColumnType("int");

                    b.Property<DateTime>("F_FecNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("F_FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("F_FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Area")
                        .HasColumnType("int");

                    b.Property<int>("Id_Ciudad")
                        .HasColumnType("int");

                    b.Property<int>("Id_CodPerfil")
                        .HasColumnType("int");

                    b.Property<int?>("PerfilesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AreasId");

                    b.HasIndex("CiudadesId");

                    b.HasIndex("PerfilesId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("LibreriaSupportFast.Models.Categorias", b =>
                {
                    b.HasOne("LibreriaSupportFast.Models.Tecnicos", "Tecnicos")
                        .WithMany()
                        .HasForeignKey("TecnicosId");

                    b.Navigation("Tecnicos");
                });

            modelBuilder.Entity("LibreriaSupportFast.Models.Gestiones", b =>
                {
                    b.HasOne("LibreriaSupportFast.Models.Categorias", "Categorias")
                        .WithMany()
                        .HasForeignKey("CategoriasId");

                    b.HasOne("LibreriaSupportFast.Models.Estados", "Estados")
                        .WithMany()
                        .HasForeignKey("EstadosId");

                    b.HasOne("LibreriaSupportFast.Models.Soluciones", "Soluciones")
                        .WithMany()
                        .HasForeignKey("SolucionesId");

                    b.Navigation("Categorias");

                    b.Navigation("Estados");

                    b.Navigation("Soluciones");
                });

            modelBuilder.Entity("LibreriaSupportFast.Models.SubCategorias", b =>
                {
                    b.HasOne("LibreriaSupportFast.Models.Categorias", "Categorias")
                        .WithMany()
                        .HasForeignKey("CategoriasId");

                    b.Navigation("Categorias");
                });

            modelBuilder.Entity("LibreriaSupportFast.Models.Tickets", b =>
                {
                    b.HasOne("LibreriaSupportFast.Models.Categorias", "Categorias")
                        .WithMany()
                        .HasForeignKey("CategoriasId");

                    b.HasOne("LibreriaSupportFast.Models.Estados", "Estados")
                        .WithMany()
                        .HasForeignKey("EstadosId");

                    b.HasOne("LibreriaSupportFast.Models.Soluciones", "Soluciones")
                        .WithMany()
                        .HasForeignKey("SolucionesId");

                    b.Navigation("Categorias");

                    b.Navigation("Estados");

                    b.Navigation("Soluciones");
                });

            modelBuilder.Entity("LibreriaSupportFast.Models.Usuarios", b =>
                {
                    b.HasOne("LibreriaSupportFast.Models.Areas", "Areas")
                        .WithMany()
                        .HasForeignKey("AreasId");

                    b.HasOne("LibreriaSupportFast.Models.Ciudades", "Ciudades")
                        .WithMany()
                        .HasForeignKey("CiudadesId");

                    b.HasOne("LibreriaSupportFast.Models.Perfiles", "Perfiles")
                        .WithMany()
                        .HasForeignKey("PerfilesId");

                    b.Navigation("Areas");

                    b.Navigation("Ciudades");

                    b.Navigation("Perfiles");
                });
#pragma warning restore 612, 618
        }
    }
}
