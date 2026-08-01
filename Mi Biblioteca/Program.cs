using Microsoft.EntityFrameworkCore;
using MiBiblioteca.Application.Services;
using MiBiblioteca.Domain.Interfaces;
using MiBiblioteca.Infrastructure.Data;
using MiBiblioteca.Infrastructure.Repositories;


var builder = WebApplication.CreateBuilder(args);


// Controllers
builder.Services.AddControllers();


// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<BibliotecaDbContext>(
    options =>
    options.UseNpgsql(
        builder.Configuration
        .GetConnectionString("DefaultConnection")
    )
);

// Repositories
builder.Services.AddScoped<ILibroRepository, LibroRepository>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IPrestamoRepository, PrestamoRepository>();


// Services
builder.Services.AddScoped<LibroService>();
builder.Services.AddScoped<UsuarioService>();
builder.Services.AddScoped<PrestamoService>();


var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();


app.UseAuthorization();


app.MapControllers();


app.Run();