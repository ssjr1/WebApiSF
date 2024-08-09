using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibreriaSupportFast.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
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
                    C_Cedula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    C_Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    C_Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    F_FecNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_CodPerfil = table.Column<int>(type: "int", nullable: false),
                    PerfilesId = table.Column<int>(type: "int", nullable: true),
                    Id_Area = table.Column<int>(type: "int", nullable: false),
                    AreasId = table.Column<int>(type: "int", nullable: true),
                    Id_Ciudad = table.Column<int>(type: "int", nullable: false),
                    CiudadesId = table.Column<int>(type: "int", nullable: true),
                    C_Direcciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    F_FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    F_FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Areas_AreasId",
                        column: x => x.AreasId,
                        principalTable: "Areas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Usuarios_Ciudades_CiudadesId",
                        column: x => x.CiudadesId,
                        principalTable: "Ciudades",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Usuarios_Perfiles_PerfilesId",
                        column: x => x.PerfilesId,
                        principalTable: "Perfiles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    C_Categoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_TecnicoDefault = table.Column<int>(type: "int", nullable: false),
                    TecnicosId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categorias_Tecnicos_TecnicosId",
                        column: x => x.TecnicosId,
                        principalTable: "Tecnicos",
                        principalColumn: "Id");
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
                name: "IX_Usuarios_AreasId",
                table: "Usuarios",
                column: "AreasId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_CiudadesId",
                table: "Usuarios",
                column: "CiudadesId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_PerfilesId",
                table: "Usuarios",
                column: "PerfilesId");
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
