using EventManagement.Business.Abstract;
using EventManagement.Business.Concrete;
using EventManagement.DataAccess;
using EventManagement.DataAccess.Contexts;
using EventManagement.DataAccess.Repositories.Abstract;
using EventManagement.DataAccess.Repositories.Concrete.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddApiVersioning(config =>
{
    config.DefaultApiVersion = new ApiVersion(1, 0);
    config.AssumeDefaultVersionWhenUnspecified = true;
});
builder.Services.AddDbContext<AppDbContext>(config => config.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));

builder.Services.AddScoped<IClassRoomService, ClassRoomManager>();
builder.Services.AddScoped<IEventService, EventManager>();
builder.Services.AddScoped<ILessonService, LessonManager>();
builder.Services.AddScoped<ITeacherService, TeacherManager>();

builder.Services.AddScoped<IClassRoomRepository, ClassRoomRepository>();
builder.Services.AddScoped<IEventRepository, EventRepository>();
builder.Services.AddScoped<ILessonRepository, LessonRepository>();
builder.Services.AddScoped<ITeacherRepository, TeacherRepository>();

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
