using EventManagement.Business.Abstract;
using EventManagement.Entity;
using Microsoft.AspNetCore.Mvc;

namespace EventManagement.WebAPI.Controllers.V1;

[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/class-room")]
[ApiController]
public class ClassRoomController : ControllerBase
{
    private readonly IClassRoomService _classRoomManager;

    public ClassRoomController(IClassRoomService classRoomService)
    {
        _classRoomManager = classRoomService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _classRoomManager.GetAll();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _classRoomManager.GetById(id);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync(ClassRoom classRoom)
    {
        await _classRoomManager.Insert(classRoom);
        return Ok(classRoom);
    }
}
