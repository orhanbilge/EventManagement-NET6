using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManagement.Business.Abstract;
using EventManagement.Entity;

namespace EventManagement.Business.Concrete;

public class EventManager : IEventService
{
    public List<Event> GetAll()
    {
        throw new NotImplementedException();
    }

    public Event GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Insert(Event @event)
    {
        throw new NotImplementedException();
    }
}
