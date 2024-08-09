using LibreriaSupportFast.Models;
using LibreriaSupportFast.Repositorios;
using Microsoft.EntityFrameworkCore;
using static LibreriaSupportFast.Repositorios.RepositorioSubCategorias;
using static LibreriaSupportFast.Repositorios.RepositorioTickets;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>
    (options => options.UseSqlServer("name=DefaultConnection"));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRepositorioSubCategorias, RepositorioSubCategoria>();
builder.Services.AddScoped<IRepositorioTecnico, RepositorioTecnico>();
builder.Services.AddScoped<IRepositorioTickets, RepositorioTicket>();


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
