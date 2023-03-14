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
    public IEnumerable<Teacher> Get()
    {
        return _teacherManager.GetAll();
    }

    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    [HttpPost]
    public async Task PostAsync(Teacher teacher)
    {
        await _teacherManager.Insert(teacher);
    }
}
