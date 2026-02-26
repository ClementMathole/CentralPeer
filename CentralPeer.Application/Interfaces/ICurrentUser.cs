using System;

namespace CentralPeer.Application.Interfaces;
/// <summary>
/// Provides the DbContext with the authenticated user details
/// </summary>
public interface ICurrentUser
{
    Guid? UserId { get; }
    Guid? CampusId { get; }
}