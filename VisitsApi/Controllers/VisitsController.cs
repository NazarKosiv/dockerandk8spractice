using Microsoft.AspNetCore.Mvc;
using VisitsApi.Services;

namespace VisitsApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VisitsController : ControllerBase
{
    private readonly IVisitsService _visitsService;

    public VisitsController(IVisitsService visitsService)
    {
        _visitsService = visitsService;
    }

    [HttpGet]
    public async Task<IActionResult> GetVisits()
    {
        return Ok(await _visitsService.GetVisits());
    }

    [HttpPut]
    public async Task<IActionResult> IncrementVisits()
    {
        await _visitsService.IncrementVisits();
        return NoContent();
    }
}
