using Pokemon_seeker.Services.Implementations;
using Pokemon_seeker.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IPokedex_Service, Pokedex_Service>();
builder.Services.AddScoped<IPokemonJsonConverter, PokemonJsonConverter>();
builder.Services.AddCors(option =>
{
    option.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});
var app = builder.Build();

app.MapOpenApi();
app.UseSwagger();
app.UseSwaggerUI();
app.UseCors("AllowAll");
app.MapControllers();
app.UseHttpsRedirection();
app.Run();
