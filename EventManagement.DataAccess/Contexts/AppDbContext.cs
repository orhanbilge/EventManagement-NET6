using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManagement.Entity;
using Microsoft.EntityFrameworkCore;

namespace EventManagement.DataAccess.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> dbContext) : base(dbContext) { }
    
    public DbSet<ClassRoom> ClassRooms { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<Lesson> Lessons { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
}
