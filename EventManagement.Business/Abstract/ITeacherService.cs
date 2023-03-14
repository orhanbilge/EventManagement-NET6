using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManagement.Entity;

namespace EventManagement.Business.Abstract;

public interface ITeacherService
{
    Task Insert(Teacher teacher);
    Task<List<Teacher>> GetAll();
    Task<Teacher> GetById(int id);
}
