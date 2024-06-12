using MassTransit;
using Microsoft.AspNetCore.Mvc;
using SharedModels;

namespace FileLinkLoader.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LinkController(IPublishEndpoint publishEndpoint) : ControllerBase
{
    private readonly IPublishEndpoint _publishEndpoint = publishEndpoint;

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] string fileUrl)
    {
        await _publishEndpoint.Publish<IUrlSent>(new { FileUrl = fileUrl });
        return Ok("File URL has been sent");
    }
}
