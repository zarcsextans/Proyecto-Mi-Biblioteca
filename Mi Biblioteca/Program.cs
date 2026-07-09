using MiBiblioteca.Application.Factories;
using MiBiblioteca.Application.Services;
using MiBiblioteca.Domain.Interfaces;
using MiBiblioteca.Infrastructure.Repositories;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();


// GoF + Servicios
builder.Services.AddSingleton<PagoFactory>();

builder.Services.AddScoped<PagoService>();


// Repository Pattern
builder.Services.AddSingleton<
    IPagoRepository,
    PagoRepository>();


builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();


var app = builder.Build();



app.UseSwagger();

app.UseSwaggerUI();


app.UseHttpsRedirection();


app.MapControllers();


app.Run();