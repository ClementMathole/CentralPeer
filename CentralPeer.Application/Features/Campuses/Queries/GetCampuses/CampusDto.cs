using System;

namespace CentralPeer.Application.Features.Campuses.Queries.GetCampuses;
/// <summary>
/// DTO to avoid sending raw data to fontend
/// </summary>
public class CampusDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
}