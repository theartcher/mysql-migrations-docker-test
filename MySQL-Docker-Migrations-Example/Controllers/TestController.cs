/*using iO_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class TestController : ControllerBase
{
    private readonly ColleagueContext _context;

    public TestController(ColleagueContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> TestDatabaseConnection()
    {
        // Query something from the database to verify the connection
        var firstColleague = await _context.Colleagues.FirstOrDefaultAsync();

        return Ok(firstColleague);
    }
}
*/