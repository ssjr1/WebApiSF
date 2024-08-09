using LibreriaSupportFast.Models;
using LibreriaSupportFast.Repositorios;
using Microsoft.EntityFrameworkCore;
using static LibreriaSupportFast.Repositorios.RepositorioSubCategorias;
<<<<<<< HEAD

var builder = WebApplication.CreateBuilder(args);

//add Cors
builder.Services.AddCors(options => options.AddPolicy("AllowWebApp",
                                builder => builder.AllowAnyOrigin()
                                .AllowAnyHeader()
                                .AllowAnyMethod()));

// Agrega la conexion de la BD
builder.Services.AddDbContext<ApplicationDbContext>(opciones =>
    opciones.UseSqlServer("name=DefaultConnection"));

=======
using static LibreriaSupportFast.Repositorios.RepositorioTickets;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>
    (options => options.UseSqlServer("name=DefaultConnection"));
>>>>>>> 735d03c26e28ffd077cda4add6c062b853091aac

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

<<<<<<< HEAD
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
=======
builder.Services.AddScoped<IRepositorioCategorias, RepositorioCategorias>();
builder.Services.AddScoped<IRepositorioSubCategorias, RepositorioSubCategoria>();
builder.Services.AddScoped<IRepositorioTecnico, RepositorioTecnico>();
builder.Services.AddScoped<IRepositorioTickets, RepositorioTicket>();
>>>>>>> 735d03c26e28ffd077cda4add6c062b853091aac


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
