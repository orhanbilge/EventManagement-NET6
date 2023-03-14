using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManagement.Business.Abstract;
using EventManagement.DataAccess.Repositories.Abstract;
using EventManagement.Entity;

namespace EventManagement.Business.Concrete;

public class ClassRoomManager : IClassRoomService
{
    readonly IClassRoomRepository _classRoomRepository;

    public ClassRoomManager(IClassRoomRepository classRoomRepository)
    {
        _classRoomRepository = classRoomRepository;
    }

    public List<ClassRoom> GetAll()
    {
        return _classRoomRepository.GetAll();
    }

    public ClassRoom GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Insert(ClassRoom classRoom)
    {
        throw new NotImplementedException();
    }
}
