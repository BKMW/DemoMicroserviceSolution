using Customer.Infra;
using Customer.Infra.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

/* Database Context Dependency Injection */

//var connectionString  = $"Data Source={dbHost};Initial Catalog={dbName};User ID=sa; Password={dbPassword}";
//var connectionString = $"Server={dbHost};Database={dbName};User Id=sa; Password={dbPassword}";
var connectionString = $"Server=customerdb;Database=customer;User Id=sa;Password=password@12345#;TrustServerCertificate=True;";

builder.Services.AddDbContext<CustomerDbContext>(opt => opt.UseSqlServer(connectionString));
builder.Services.AddInfra();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
