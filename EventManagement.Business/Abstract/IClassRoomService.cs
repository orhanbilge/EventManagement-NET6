using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManagement.Entity;

namespace EventManagement.Business.Abstract;

public interface IClassRoomService
{
    Task Insert(ClassRoom classRoom);
    Task<List<ClassRoom>> GetAll();
    Task<ClassRoom> GetById(int id);
}
