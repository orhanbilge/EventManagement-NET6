using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManagement.Business.Abstract;
using EventManagement.DataAccess.Repositories.Abstract;
using EventManagement.Entity;

namespace EventManagement.Business.Concrete;

public class LessonManager : ILessonService
{
    readonly ILessonRepository _repository;

    public LessonManager(ILessonRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<Lesson>> GetAll()
    {
        return await _repository.GetAll();
    }

    public async Task<Lesson> GetById(int id)
    {
        return await _repository.GetById(id);
    }

    public async Task Insert(Lesson lesson)
    {
        await _repository.Insert(lesson);
    }
}
