using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManagement.Entity;

namespace EventManagement.Business.Abstract;

public interface ITeacherService
{
    void Insert(Teacher teacher);
    List<Teacher> GetAll();
    Teacher GetById(int id);
}
