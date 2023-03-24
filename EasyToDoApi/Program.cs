using EasyToDoApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<EasyToDoApiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EasyToDoApiContext") ?? throw new InvalidOperationException("Connection string 'EasyToDoApiContext' not found.")));

// Add services to the container.

builder.Services.AddDbContext<ApplicationDbContext>(O => O.UseSqlServer(
    builder.Configuration.GetConnectionString("ApplicationDbContext")));

builder.Services.AddControllers();
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
