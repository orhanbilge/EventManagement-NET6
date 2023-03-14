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

    public async Task<List<ClassRoom>> GetAll()
    {
        return await _repository.GetAll();
    }

    public async Task<ClassRoom> GetById(int id)
    {
        return await _repository.GetById(id);
    }

    public async Task Insert(ClassRoom classRoom)
    {
        await _repository.Insert(classRoom);
    }
}
