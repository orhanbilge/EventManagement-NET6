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
    readonly IClassRoomRepository _repository;

    public ClassRoomManager(IClassRoomRepository repository)
    {
        _repository = repository;
    }

    public List<ClassRoom> GetAll()
    {
        return _repository.GetAll();
    }

    public ClassRoom GetById(int id)
    {
        throw new NotImplementedException();
    }

    public async Task Insert(ClassRoom classRoom)
    {
        await _repository.Insert(classRoom);
    }
}
