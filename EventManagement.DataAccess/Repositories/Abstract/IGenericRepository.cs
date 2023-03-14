using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.DataAccess.Repositories.Abstract;

public interface IGenericRepository<Entity> where Entity : class
{
    void Insert(Entity entity);
    List<Entity> GetAll();
    Entity GetById(int id);
}