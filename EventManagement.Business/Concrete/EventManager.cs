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

    public List<Event> GetAll()
    {
        throw new NotImplementedException();
    }

    public Event GetById(int id)
    {
        throw new NotImplementedException();
    }

    public async Task Insert(Event @event)
    {
        await _repository.Insert(@event);
    }
}
