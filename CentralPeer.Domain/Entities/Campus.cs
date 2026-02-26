using CentralPeer.Domain.Common;
using System.Collections.Generic;

namespace CentralPeer.Domain.Entities;
/// <summary>
/// Represents the university campus
/// Acts as the core tenant identifier for data isolation
/// </summary>
public class Campus : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public ICollection<User> Users { get; set; } = new List<User>(); // campus has many registered users(students)
}