using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibreriaSupportFast.Migrations
{
    /// <inheritdoc />
    public partial class SupportFast : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    c_Area = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Ciudades",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    c_Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudades", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    c_Estado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Perfiles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    c_Perfil = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfiles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Soluciones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    c_Solucion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    l_solucion_definitiva = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Soluciones", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Tecnicos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    c_Tecnico = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tecnicos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    c_Cedula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    c_Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    c_Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    f_FecNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    id_CodPerfil = table.Column<int>(type: "int", nullable: false),
                    perfilesid = table.Column<int>(type: "int", nullable: false),
                    id_Area = table.Column<int>(type: "int", nullable: false),
                    areasid = table.Column<int>(type: "int", nullable: false),
                    id_Ciudad = table.Column<int>(type: "int", nullable: false),
                    ciudadesid = table.Column<int>(type: "int", nullable: false),
                    c_Direccione = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    f_FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    f_FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Areas_areasid",
                        column: x => x.areasid,
                        principalTable: "Areas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuarios_Ciudades_ciudadesid",
                        column: x => x.ciudadesid,
                        principalTable: "Ciudades",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuarios_Perfiles_perfilesid",
                        column: x => x.perfilesid,
                        principalTable: "Perfiles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    c_Categoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id_TecnicoDefault = table.Column<int>(type: "int", nullable: false),
                    tecnicosid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.id);
                    table.ForeignKey(
                        name: "FK_Categorias_Tecnicos_tecnicosid",
                        column: x => x.tecnicosid,
                        principalTable: "Tecnicos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gestiones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_Ticket = table.Column<int>(type: "int", nullable: false),
                    id_categoria = table.Column<int>(type: "int", nullable: false),
                    categoriasid = table.Column<int>(type: "int", nullable: false),
                    id_subcategoria = table.Column<int>(type: "int", nullable: false),
                    id_tecnico_asignado = table.Column<int>(type: "int", nullable: false),
                    id_solucion = table.Column<int>(type: "int", nullable: false),
                    solucionesid = table.Column<int>(type: "int", nullable: false),
                    id_estado = table.Column<int>(type: "int", nullable: false),
                    estadosid = table.Column<int>(type: "int", nullable: false),
                    f_fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    f_fecha_cierre = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gestiones", x => x.id);
                    table.ForeignKey(
                        name: "FK_Gestiones_Categorias_categoriasid",
                        column: x => x.categoriasid,
                        principalTable: "Categorias",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gestiones_Estados_estadosid",
                        column: x => x.estadosid,
                        principalTable: "Estados",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gestiones_Soluciones_solucionesid",
                        column: x => x.solucionesid,
                        principalTable: "Soluciones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubCategorias",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_Categoria = table.Column<int>(type: "int", nullable: false),
                    categoriasid = table.Column<int>(type: "int", nullable: false),
                    c_SubCategoria = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategorias", x => x.id);
                    table.ForeignKey(
                        name: "FK_SubCategorias_Categorias_categoriasid",
                        column: x => x.categoriasid,
                        principalTable: "Categorias",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
<<<<<<<< HEAD:LibreriaSupportFast/Migrations/20240808085542_SupportFast.cs
            name: "Tickets",
            columns: table => new
            {
                id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                c_Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                id_categoria = table.Column<int>(type: "int", nullable: false),
                categoriasid = table.Column<int>(type: "int", nullable: false),
                id_subcategoria = table.Column<int>(type: "int", nullable: false),
                subCategoriasid = table.Column<int>(type: "int", nullable: false),
                id_tecnico_asignado = table.Column<int>(type: "int", nullable: false),
                tecnicosid = table.Column<int>(type: "int", nullable: false),
                id_solucion = table.Column<int>(type: "int", nullable: false),
                solucionesid = table.Column<int>(type: "int", nullable: false),
                id_estado = table.Column<int>(type: "int", nullable: false),
                estadosid = table.Column<int>(type: "int", nullable: false),
                f_fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                f_fecha_Ultima_Gestion = table.Column<DateTime>(type: "datetime2", nullable: false),
                f_fecha_cierre = table.Column<DateTime>(type: "datetime2", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Tickets", x => x.id);
                table.ForeignKey(
                    name: "FK_Tickets_Categorias_categoriasid",
                    column: x => x.categoriasid,
                    principalTable: "Categorias",
                    principalColumn: "id",
                    onDelete: ReferentialAction.Restrict); // Cambiado a Restrict
                table.ForeignKey(
                    name: "FK_Tickets_Estados_estadosid",
                    column: x => x.estadosid,
                    principalTable: "Estados",
                    principalColumn: "id",
                    onDelete: ReferentialAction.Restrict); // Cambiado a Restrict
                table.ForeignKey(
                    name: "FK_Tickets_Soluciones_solucionesid",
                    column: x => x.solucionesid,
                    principalTable: "Soluciones",
                    principalColumn: "id",
                    onDelete: ReferentialAction.Restrict); // Cambiado a Restrict
                table.ForeignKey(
                    name: "FK_Tickets_SubCategorias_subCategoriasid",
                    column: x => x.subCategoriasid,
                    principalTable: "SubCategorias",
                    principalColumn: "id",
                    onDelete: ReferentialAction.Restrict); // Cambiado a Restrict
                table.ForeignKey(
                    name: "FK_Tickets_Tecnicos_tecnicosid",
                    column: x => x.tecnicosid,
                    principalTable: "Tecnicos",
                    principalColumn: "id",
                    onDelete: ReferentialAction.Restrict); // Cambiado a Restrict
            });

            migrationBuilder.CreateTable(
            name: "Gestiones",
            columns: table => new
            {
                id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                id_Ticket = table.Column<int>(type: "int", nullable: false),
                ticketid = table.Column<int>(type: "int", nullable: false),
                id_categoria = table.Column<int>(type: "int", nullable: false),
                categoriasid = table.Column<int>(type: "int", nullable: false),
                id_subcategoria = table.Column<int>(type: "int", nullable: false),
                subCategoriasid = table.Column<int>(type: "int", nullable: false),
                id_tecnico_asignado = table.Column<int>(type: "int", nullable: false),
                tecnicosid = table.Column<int>(type: "int", nullable: false),
                id_solucion = table.Column<int>(type: "int", nullable: false),
                solucionesid = table.Column<int>(type: "int", nullable: false),
                id_estado = table.Column<int>(type: "int", nullable: false),
                estadosid = table.Column<int>(type: "int", nullable: false),
                f_fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                f_fecha_cierre = table.Column<DateTime>(type: "datetime2", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Gestiones", x => x.id);
                table.ForeignKey(
                    name: "FK_Gestiones_Categorias_categoriasid",
                    column: x => x.categoriasid,
                    principalTable: "Categorias",
                    principalColumn: "id",
                    onDelete: ReferentialAction.Restrict); // Cambiado a Restrict
                table.ForeignKey(
                    name: "FK_Gestiones_Estados_estadosid",
                    column: x => x.estadosid,
                    principalTable: "Estados",
                    principalColumn: "id",
                    onDelete: ReferentialAction.Restrict); // Cambiado a Restrict
                table.ForeignKey(
                    name: "FK_Gestiones_Soluciones_solucionesid",
                    column: x => x.solucionesid,
                    principalTable: "Soluciones",
                    principalColumn: "id",
                    onDelete: ReferentialAction.Restrict); // Cambiado a Restrict
                table.ForeignKey(
                    name: "FK_Gestiones_SubCategorias_subCategoriasid",
                    column: x => x.subCategoriasid,
                    principalTable: "SubCategorias",
                    principalColumn: "id",
                    onDelete: ReferentialAction.Restrict); // Cambiado a Restrict
                table.ForeignKey(
                    name: "FK_Gestiones_Tecnicos_tecnicosid",
                    column: x => x.tecnicosid,
                    principalTable: "Tecnicos",
                    principalColumn: "id",
                    onDelete: ReferentialAction.Restrict); // Cambiado a Restrict
                table.ForeignKey(
                    name: "FK_Gestiones_Tickets_ticketid",
                    column: x => x.ticketid,
                    principalTable: "Tickets",
                    principalColumn: "id",
                    onDelete: ReferentialAction.Restrict); // Cambiado a Restrict
            });
========
                name: "Tickets",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    c_Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id_categoria = table.Column<int>(type: "int", nullable: false),
                    categoriasid = table.Column<int>(type: "int", nullable: false),
                    id_SubCategoria = table.Column<int>(type: "int", nullable: false),
                    id_tecnico_asignado = table.Column<int>(type: "int", nullable: false),
                    id_solucion = table.Column<int>(type: "int", nullable: false),
                    solucionesid = table.Column<int>(type: "int", nullable: false),
                    id_estado = table.Column<int>(type: "int", nullable: false),
                    estadosid = table.Column<int>(type: "int", nullable: false),
                    f_fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    f_fecha_Ultima_Gestion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    f_fecha_cierre = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.id);
                    table.ForeignKey(
                        name: "FK_Tickets_Categorias_categoriasid",
                        column: x => x.categoriasid,
                        principalTable: "Categorias",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Estados_estadosid",
                        column: x => x.estadosid,
                        principalTable: "Estados",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Soluciones_solucionesid",
                        column: x => x.solucionesid,
                        principalTable: "Soluciones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });
>>>>>>>> 0ca240120a83ba4e38b370f39b79d8d224ea193b:LibreriaSupportFast/Migrations/20240808090128_init.cs

            migrationBuilder.CreateIndex(
                name: "IX_Categorias_tecnicosid",
                table: "Categorias",
                column: "tecnicosid");

            migrationBuilder.CreateIndex(
                name: "IX_Gestiones_categoriasid",
                table: "Gestiones",
                column: "categoriasid");

            migrationBuilder.CreateIndex(
                name: "IX_Gestiones_estadosid",
                table: "Gestiones",
                column: "estadosid");

            migrationBuilder.CreateIndex(
                name: "IX_Gestiones_solucionesid",
                table: "Gestiones",
                column: "solucionesid");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategorias_categoriasid",
                table: "SubCategorias",
                column: "categoriasid");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_categoriasid",
                table: "Tickets",
                column: "categoriasid");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_estadosid",
                table: "Tickets",
                column: "estadosid");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_solucionesid",
                table: "Tickets",
                column: "solucionesid");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_areasid",
                table: "Usuarios",
                column: "areasid");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_ciudadesid",
                table: "Usuarios",
                column: "ciudadesid");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_perfilesid",
                table: "Usuarios",
                column: "perfilesid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gestiones");

            migrationBuilder.DropTable(
                name: "SubCategorias");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Estados");

            migrationBuilder.DropTable(
                name: "Soluciones");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "Ciudades");

            migrationBuilder.DropTable(
                name: "Perfiles");

            migrationBuilder.DropTable(
                name: "Tecnicos");
        }
    }
}
