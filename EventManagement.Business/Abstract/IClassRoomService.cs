using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManagement.Entity;

namespace EventManagement.Business.Abstract;

public interface IClassRoomService
{
    void Insert(ClassRoom classRoom);
    List<ClassRoom> GetAll();
    ClassRoom GetById(int id);
}
