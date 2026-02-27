using CentralPeer.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CentralPeer.Application.Features.Campuses.Queries.GetCampuses;

public class GetCampusesQueryHandler : IRequestHandler<GetCampusesQuery, List<CampusDto>>
{
    private readonly IApplicationDbContext _context;

    public GetCampusesQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Fetch campuses from postgresql and map them to the dto
    /// </summary>
    /// <param name="request"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<List<CampusDto>> Handle(GetCampusesQuery request, CancellationToken ct)
        => await _context.Campuses
                         .Select(c => new CampusDto
                         {
                             Id = c.Id,
                             Name = c.Name
                         })
                         .ToListAsync(ct);
}