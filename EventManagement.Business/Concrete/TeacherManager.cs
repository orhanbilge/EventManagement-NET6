using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManagement.Business.Abstract;
using EventManagement.DataAccess.Repositories.Abstract;
using EventManagement.Entity;

namespace EventManagement.Business.Concrete;

public class TeacherManager : ITeacherService
{
    readonly ITeacherRepository _repository;

    public TeacherManager(ITeacherRepository repository)
    {
        _repository = repository;
    }

    public List<Teacher> GetAll()
    {
        throw new NotImplementedException();
    }

    public Teacher GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Insert(Teacher teacher)
    {
        throw new NotImplementedException();
    }
}
