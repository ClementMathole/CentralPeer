using CentralPeer.Application.Interfaces;
using System;

namespace CentralPeer.API.Services;
/// <summary>
/// will later implement to extract UserId and CampusId
/// from HTTP Context JWT Claims
/// </summary>
public class CurrentUserService : ICurrentUser
{
    public Guid? UserId => null;
    public Guid? CampusId => null;
}