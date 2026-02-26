using CentralPeer.Domain.Common;
using CentralPeer.Domain.Enums;

namespace CentralPeer.Domain.Entities;
/// <summary>
/// Represents a scheduled tutoring session
/// </summary>
public class Booking : BaseEntity
{
    public Guid StudentId { get; set; }
    public User? Student { get; set; }

    public Guid TutorId { get; set; }
    public TutorProfile? Tutor { get; set; }

    public Guid SubjectId { get; set; }
    public Subject? Subject { get; set; }

    public DateTime SessionDate { get; set; }

    public BookingStatus Status { get; set; } = BookingStatus.Pending;

    /// <summary>
    /// Optional notes from student
    /// </summary>
    public string MeetingNotes { get; set; } = string.Empty;
}