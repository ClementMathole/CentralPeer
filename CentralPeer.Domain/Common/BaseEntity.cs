using System;

namespace CentralPeer.Domain.Common;
/// <summary>
/// Abstract base class for common properties for all domain entities
/// </summary>
public abstract class BaseEntity
{
    /// <summary>
    /// Global unique ID for the entity
    /// Using Guid to prevent enumeration attacks
    /// </summary>
    public Guid Id { get; set; } = Guid.NewGuid();
    
    /// <summary>
    /// Timestamp of when the record was inserted into db
    /// </summary>
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Timestamp of the last update
    /// </summary>
    public DateTime? UpdatedAt { get; set; }
}