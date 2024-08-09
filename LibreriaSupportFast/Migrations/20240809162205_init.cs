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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    C_Area = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ciudades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    C_Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    C_Estado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Perfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    C_Perfil = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Soluciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    C_Solucion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    L_solucion_definitiva = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Soluciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tecnicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    C_Tecnico = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tecnicos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    c_Cedula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    c_Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    c_Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    f_FecNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    id_CodPerfil = table.Column<int>(type: "int", nullable: false),
                    perfilesId = table.Column<int>(type: "int", nullable: false),
                    id_Area = table.Column<int>(type: "int", nullable: false),
                    areasId = table.Column<int>(type: "int", nullable: false),
                    id_Ciudad = table.Column<int>(type: "int", nullable: false),
                    ciudadesId = table.Column<int>(type: "int", nullable: false),
                    c_Direccione = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    f_FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    f_FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Areas_areasId",
                        column: x => x.areasId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuarios_Ciudades_ciudadesId",
                        column: x => x.ciudadesId,
                        principalTable: "Ciudades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuarios_Perfiles_perfilesId",
                        column: x => x.perfilesId,
                        principalTable: "Perfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    C_Categoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_TecnicoDefault = table.Column<int>(type: "int", nullable: false),
                    TecnicosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categorias_Tecnicos_TecnicosId",
                        column: x => x.TecnicosId,
                        principalTable: "Tecnicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gestiones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Ticket = table.Column<int>(type: "int", nullable: false),
                    Id_categoria = table.Column<int>(type: "int", nullable: false),
                    CategoriasId = table.Column<int>(type: "int", nullable: true),
                    Id_subcategoria = table.Column<int>(type: "int", nullable: false),
                    Id_tecnico_asignado = table.Column<int>(type: "int", nullable: false),
                    Id_solucion = table.Column<int>(type: "int", nullable: false),
                    SolucionesId = table.Column<int>(type: "int", nullable: true),
                    Id_estado = table.Column<int>(type: "int", nullable: false),
                    EstadosId = table.Column<int>(type: "int", nullable: true),
                    F_fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    F_fecha_cierre = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gestiones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gestiones_Categorias_CategoriasId",
                        column: x => x.CategoriasId,
                        principalTable: "Categorias",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Gestiones_Estados_EstadosId",
                        column: x => x.EstadosId,
                        principalTable: "Estados",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Gestiones_Soluciones_SolucionesId",
                        column: x => x.SolucionesId,
                        principalTable: "Soluciones",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SubCategorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Categoria = table.Column<int>(type: "int", nullable: false),
                    CategoriasId = table.Column<int>(type: "int", nullable: true),
                    C_SubCategoria = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategorias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategorias_Categorias_CategoriasId",
                        column: x => x.CategoriasId,
                        principalTable: "Categorias",
                        principalColumn: "Id");
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    C_Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_categoria = table.Column<int>(type: "int", nullable: false),
                    CategoriasId = table.Column<int>(type: "int", nullable: true),
                    Id_SubCategoria = table.Column<int>(type: "int", nullable: false),
                    Id_tecnico_asignado = table.Column<int>(type: "int", nullable: false),
                    Id_solucion = table.Column<int>(type: "int", nullable: false),
                    SolucionesId = table.Column<int>(type: "int", nullable: true),
                    Id_estado = table.Column<int>(type: "int", nullable: false),
                    EstadosId = table.Column<int>(type: "int", nullable: true),
                    F_fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    F_fecha_Ultima_Gestion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    F_fecha_cierre = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Categorias_CategoriasId",
                        column: x => x.CategoriasId,
                        principalTable: "Categorias",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tickets_Estados_EstadosId",
                        column: x => x.EstadosId,
                        principalTable: "Estados",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tickets_Soluciones_SolucionesId",
                        column: x => x.SolucionesId,
                        principalTable: "Soluciones",
                        principalColumn: "Id");
                });
>>>>>>>> 1b951a99c2096561074a0da66a3a866f633caf6b:LibreriaSupportFast/Migrations/20240808090128_init.cs

            migrationBuilder.CreateIndex(
                name: "IX_Categorias_TecnicosId",
                table: "Categorias",
                column: "TecnicosId");

            migrationBuilder.CreateIndex(
                name: "IX_Gestiones_CategoriasId",
                table: "Gestiones",
                column: "CategoriasId");

            migrationBuilder.CreateIndex(
                name: "IX_Gestiones_EstadosId",
                table: "Gestiones",
                column: "EstadosId");

            migrationBuilder.CreateIndex(
                name: "IX_Gestiones_SolucionesId",
                table: "Gestiones",
                column: "SolucionesId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategorias_CategoriasId",
                table: "SubCategorias",
                column: "CategoriasId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_CategoriasId",
                table: "Tickets",
                column: "CategoriasId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_EstadosId",
                table: "Tickets",
                column: "EstadosId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_SolucionesId",
                table: "Tickets",
                column: "SolucionesId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_areasId",
                table: "Usuarios",
                column: "areasId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_ciudadesId",
                table: "Usuarios",
                column: "ciudadesId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_perfilesId",
                table: "Usuarios",
                column: "perfilesId");
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
