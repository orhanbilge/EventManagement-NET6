using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManagement.Entity;

namespace EventManagement.Business.Abstract;

public interface ILessonService
{
    void Insert(Lesson lesson);
    List<Lesson> GetAll();
    Lesson GetById(int id);
}
