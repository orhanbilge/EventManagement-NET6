using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManagement.Business.Abstract;
using EventManagement.DataAccess.Repositories.Abstract;
using EventManagement.Entity;

namespace EventManagement.Business.Concrete;

public class EventManager : IEventService
{
    readonly IEventRepository _repository;

    public EventManager(IEventRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<Event>> GetAll()
    {
        return await _repository.GetAll();
    }

    public async Task<Event> GetById(int id)
    {
        return await _repository.GetById(id);
    }

    public async Task Insert(Event @event)
    {
        await _repository.Insert(@event);
    }
}
