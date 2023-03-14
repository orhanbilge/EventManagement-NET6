using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManagement.DataAccess.Contexts;
using EventManagement.DataAccess.Repositories.Abstract;

namespace EventManagement.DataAccess.Repositories.Concrete.EntityFrameworkCore;

public class GenericRepository<Entity> : IGenericRepository<Entity> where Entity : class
{
    readonly AppDbContext _context;

    public GenericRepository(AppDbContext dbContext)
    {
        _context = dbContext;
    }

    public List<Entity> GetAll()
    {
        return _context.Set<Entity>().ToList();
    }

    public Entity GetById(int id)
    {
        throw new NotImplementedException();
    }

    public async Task Insert(Entity entity)
    {
        _ = _context.Set<Entity>().AddAsync(entity);
        await _context.SaveChangesAsync();
    }
}
