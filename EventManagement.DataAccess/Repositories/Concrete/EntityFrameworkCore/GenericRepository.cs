using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManagement.DataAccess.Repositories.Abstract;

namespace EventManagement.DataAccess.Repositories.Concrete.EntityFrameworkCore;

public class GenericRepository<Entity> : IGenericRepository<Entity> where Entity : class
{
    public List<Entity> GetAll()
    {
        throw new NotImplementedException();
    }

    public Entity GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Insert(Entity entity)
    {
        throw new NotImplementedException();
    }
}
