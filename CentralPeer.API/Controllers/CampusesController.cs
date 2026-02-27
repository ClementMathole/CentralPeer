using CentralPeer.Application.Features.Campuses.Queries.GetCampuses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CentralPeer.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CampusesController : ControllerBase
{
    private readonly ISender _sender;

    public CampusesController(ISender sender)
    {
        _sender = sender;
    }

    /// <summary>
    /// Sends the query into the MediatR pipeline
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<ActionResult<List<CampusDto>>> GetCampuses()
    {
        var campuses = await _sender.Send(new GetCampusesQuery());
        return Ok(campuses);
    }
}