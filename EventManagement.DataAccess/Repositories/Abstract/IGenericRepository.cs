using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.DataAccess.Repositories.Abstract;

public interface IGenericRepository<Entity> where Entity : class
{
    Task Insert(Entity entity);
    Task<List<Entity>> GetAll();
    Task<Entity> GetById(int id);
}