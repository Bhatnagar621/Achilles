using Microsoft.EntityFrameworkCore;
using PersonService.Infrastructure.PersonDbContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var environment = builder.Environment.EnvironmentName; // e.g., Development, Staging, Production
Console.WriteLine($"Current Environment: {environment}");

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<PersonDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgresConnection")));

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
