using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Butler.Api.Users.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpGet]
    public IActionResult GetUser()
    {
        return Ok();
    }
}