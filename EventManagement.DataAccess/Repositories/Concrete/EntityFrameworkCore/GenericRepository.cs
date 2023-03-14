using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManagement.DataAccess.Contexts;
using EventManagement.DataAccess.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace EventManagement.DataAccess.Repositories.Concrete.EntityFrameworkCore;

public class GenericRepository<Entity> : IGenericRepository<Entity> where Entity : class
{
    readonly AppDbContext _context;

    public GenericRepository(AppDbContext dbContext)
    {
        _context = dbContext;
    }

    public async Task<List<Entity>> GetAll()
    {
        return await _context.Set<Entity>().ToListAsync();
    }

    public async Task<Entity> GetById(int id)
    {
        return await _context.Set<Entity>().FindAsync(id);
    }

    public async Task Insert(Entity entity)
    {
        _ = _context.Set<Entity>().AddAsync(entity);
        await _context.SaveChangesAsync();
    }
}
