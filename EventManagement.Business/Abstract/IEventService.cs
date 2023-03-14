using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManagement.Entity;

namespace EventManagement.Business.Abstract;

public interface IEventService
{
    void Insert(Event @event);
    List<Event> GetAll();
    Event GetById(int id);
}
