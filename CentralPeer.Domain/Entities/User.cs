using CentralPeer.Domain.Common;
using CentralPeer.Domain.Enums;
using System;
using System.Collections.Generic;

namespace CentralPeer.Domain.Entities;
/// <summary>
/// Core entity representing a verified student
/// </summary>
public class User : BaseEntity
{
    /// <summary>
    /// Tenant ID linking user strictly to specific campus
    /// </summary>
    public Guid CampusId { get; set; }
    public Campus? Campus { get; set; }

    public string FullName { get; set; } = string.Empty;
    public string StudentNumber { get; set; } = string.Empty;

    /// <summary>
    /// Official university email
    /// ending with the exact university provided domain
    /// </summary>
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;

    /// <summary>
    /// Security flag ensuring the student clicked the link
    /// in their Outlook inbox
    /// </summary>
    public bool EmailConfirmed { get; set; } = false;

    public UserRole Role { get; set; } = UserRole.Student;

    public TutorProfile? TutorProfile { get; set; }
    public ICollection<Booking> BookingsAsStudent { get; set; } = new List<Booking>();
    public ICollection<ChatMessage> SentMessages { get; set; } = new List<ChatMessage>();
    public ICollection<ChatMessage> ReceivedMessages { get; set; } = new List<ChatMessage>();
}