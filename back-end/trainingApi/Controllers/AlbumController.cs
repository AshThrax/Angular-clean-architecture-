using Microsoft.AspNetCore.Mvc;

namespace trainingApi.Controllers;

[ApiController]
[Route("api/[controller]")]

public class AlbumController : ControllerBase
{
    private readonly ILogger<AlbumController> _albumLogger;
    public ConcertController(ILogger<ConcertController> albumLogger)
    {
        _albumLogger = albumLogger;
    }
    [HttpGet]
    [route("/")]
    public List<Album> GetAlbum()
    {
        return
    }
    [HttpGet]
    [route("/{id}")]
    public Concert GetAlbumById()
    {
        return
    }
    [HttpPost]
    [route("/{id}")]
    public void PostAlbum([Frombody] Concert Postconcert)
    {
        return
    }
}