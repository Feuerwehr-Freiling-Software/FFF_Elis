using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EPAS.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class OperationController : Controller
{
    [HttpGet, Authorize]
    public IActionResult Get()
    {
        return Ok();
    }
}