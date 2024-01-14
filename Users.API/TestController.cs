using Microsoft.AspNetCore.Mvc;

namespace Users.API;

public class TestController : ControllerBase
{
    [HttpGet("users/test")]
    public async Task<IActionResult> Get()
    {
        await Task.CompletedTask;
        return Ok("Test");
    }
}