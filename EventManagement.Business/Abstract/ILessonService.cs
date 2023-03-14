using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManagement.Entity;

namespace EventManagement.Business.Abstract;

public interface ILessonService
{
    Task Insert(Lesson lesson);
    Task<List<Lesson>> GetAll();
    Task<Lesson> GetById(int id);
}
