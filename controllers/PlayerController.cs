using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class PlayersController : ControllerBase
{
    private static readonly List<Player> Players = new List<Player>
    {
        new Player { Id = 1, Name = "Player 1", TeamId = 1 },
        new Player { Id = 2, Name = "Player 2", TeamId = 2 }
    };

    [HttpGet]
    public IEnumerable<Player> Get() => Players;
}