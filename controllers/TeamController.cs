using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class TeamsController : ControllerBase
{
    private static readonly List<Team> Teams = new List<Team>
    {
        new Team { Id = 1, Name = "Team A" },
        new Team { Id = 2, Name = "Team B" }
    };

    [HttpGet]
    public IEnumerable<Team> Get() => Teams;
}