﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManagement.Entity;

namespace EventManagement.Business.Abstract;

public interface IEventService
{
    Task Insert(Event @event);
    Task<List<Event>> GetAll();
    Task<Event> GetById(int id);
}
