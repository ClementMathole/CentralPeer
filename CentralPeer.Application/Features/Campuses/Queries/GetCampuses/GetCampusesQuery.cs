using MediatR;

namespace CentralPeer.Application.Features.Campuses.Queries.GetCampuses;

/// <summary>
/// Asks the system for a list of CampustDto objects
/// </summary>
public record GetCampusesQuery : IRequest<List<CampusDto>>;