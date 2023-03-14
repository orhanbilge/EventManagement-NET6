using EventManagement.Business.Abstract;
using EventManagement.Entity;
using Microsoft.AspNetCore.Mvc;

namespace EventManagement.WebAPI.Controllers.V1;

[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/event")]
[ApiController]
public class EventController : ControllerBase
{
    private readonly IEventService _eventManager;

    public EventController(IEventService eventService)
    {
        _eventManager = eventService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _eventManager.GetAll();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _eventManager.GetById(id);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync(Event @event)
    {
        await _eventManager.Insert(@event);
        return Ok(@event);
    }
}
