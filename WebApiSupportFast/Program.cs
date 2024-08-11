using LibreriaSupportFast.Models;
using LibreriaSupportFast.Repositorios;
using Microsoft.EntityFrameworkCore;
using static LibreriaSupportFast.Repositorios.RepositorioSubCategorias;

var builder = WebApplication.CreateBuilder(args);

// Agrega CORS
builder.Services.AddCors(options => options.AddPolicy("AllowWebApp",
    builder => builder.AllowAnyOrigin()
                      .AllowAnyHeader()
                      .AllowAnyMethod()));

// Agrega la conexión de la base de datos
builder.Services.AddDbContext<ApplicationDbContext>(opciones =>
    opciones.UseSqlServer("name=DefaultConnection"));

// Agrega servicios al contenedor.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRepositorioAreas, RepositorioAreas>();
builder.Services.AddScoped<IRepositorioCategorias, RepositorioCategorias>();
builder.Services.AddScoped<IRepositorioCiudades, RepositorioCiudades>();
builder.Services.AddScoped<IRepositorioEstados, RepositorioEstados>();
builder.Services.AddScoped<IRepositorioGestiones, RepositorioGestiones>();
builder.Services.AddScoped<IRepositorioPerfiles, RepositorioPerfiles>();
builder.Services.AddScoped<IRepositorioSoluciones, RepositorioSoluciones>();
builder.Services.AddScoped<IRepositorioSubCategorias, RepositorioSubCategoria>();
builder.Services.AddScoped<IRepositorioTecnico, RepositorioTecnico>();
builder.Services.AddScoped<IRepositorioTickets, RepositorioTickets>();
builder.Services.AddScoped<IRepositorioUsuarios, RepositorioUsuarios>();

var app = builder.Build();

// Configuración del pipeline de solicitudes HTTP.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Aplica la política de CORS antes de Authorization
app.UseCors("AllowWebApp");

app.UseAuthorization();

app.MapControllers();

app.Run();

