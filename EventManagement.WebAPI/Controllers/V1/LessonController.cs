using EventManagement.Business.Abstract;
using EventManagement.Entity;
using Microsoft.AspNetCore.Mvc;

namespace EventManagement.WebAPI.Controllers.V1;

[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/lesson")]
[ApiController]
public class LessonController : ControllerBase
{
    private readonly ILessonService _lessonManager;

    public LessonController(ILessonService lessonService)
    {
        _lessonManager = lessonService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _lessonManager.GetAll();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _lessonManager.GetById(id);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync(Lesson lesson)
    {
        await _lessonManager.Insert(lesson);
        return Ok(lesson);
    }
}
