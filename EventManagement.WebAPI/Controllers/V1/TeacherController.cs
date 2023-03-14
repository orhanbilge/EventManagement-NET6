using EventManagement.Business.Abstract;
using EventManagement.Entity;
using Microsoft.AspNetCore.Mvc;

namespace EventManagement.WebAPI.Controllers.V1;

[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/teacher")]
[ApiController]
public class TeacherController : ControllerBase
{
    private readonly ITeacherService _teacherManager;

    public TeacherController(ITeacherService teacherService)
    {
        _teacherManager = teacherService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _teacherManager.GetAll();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _teacherManager.GetById(id);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync(Teacher teacher)
    {
        await _teacherManager.Insert(teacher);
        return Ok(teacher);
    }
}
