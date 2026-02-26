namespace CentralPeer.Domain.Enums;

/// <summary>
/// Tracks the lifecycle of a tutoring session
/// </summary>
public enum BookingStatus
{
    Pending = 0, // Student requested a session with Tutor
    Accepted = 1, // Tutor agreed to the session
    Completed = 2, // Session took place successfully
    Cancelled = 3 // Session aborted by either party
}