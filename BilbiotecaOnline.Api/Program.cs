using BibliotecaOnline.Infrastructure;
using BibliotecaOnline.Infrastructure.Context;
using BibliotecaOnline.Services.Interfaces;
using BibliotecaOnline.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<BibliotecaContext>(options =>
    options.UseSqlServer("Server=BOTELHO\\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=true;TrustServerCertificate=true"));

builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
//builder.Services.AddScoped<ILivroRepository, LivroRepository>();
//builder.Services.AddScoped<IEmprestimoRepository, EmprestimoRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
