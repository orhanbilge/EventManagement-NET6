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

    public async Task<List<Teacher>> GetAll()
    {
        return await _repository.GetAll();
    }

    public async Task<Teacher> GetById(int id)
    {
        return await _repository.GetById(id);
    }

    public async Task Insert(Teacher teacher)
    {
        await _repository.Insert(teacher);
    }
}
