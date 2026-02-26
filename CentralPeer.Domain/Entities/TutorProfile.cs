using System;
using System.Collections.Generic;

namespace CentralPeer.Domain.Entities;
/// <summary>
/// Extension of User, only if student chose to become a tutor
/// </summary>
public class TutorProfile
{
    public Guid UserId { get; set; }
    public User? User { get; set; }
    public string Bio { get; set; }
    public decimal HourlyRate { get; set; }

    /// <summary>
    /// Payment method(cash.EFT)
    /// </summary>
    public string AcceptedPaymentMethods { get; set; } = string.Empty;

    public bool IsActive { get; set; } = true;

    public ICollection<TutorSubject> TutorSubjects { get; set; } = new List<TutorSubject>();
    public ICollection<Booking> BookingsAsTutor { get; set; } = new List<Booking>();
}