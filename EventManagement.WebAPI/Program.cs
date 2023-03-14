using EventManagement.DataAccess.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddApiVersioning(_ =>
{
    _.DefaultApiVersion = new ApiVersion(1, 0);
    _.AssumeDefaultVersionWhenUnspecified = true;
});
builder.Services.AddDbContext<AppDbContext>(config => config.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));
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
