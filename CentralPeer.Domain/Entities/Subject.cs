using CentralPeer.Domain.Common;
using System.Collections.Generic;

namespace CentralPeer.Domain.Entities;
/// <summary>
/// Represents a specific academic module(e..g, SOD316C - Software Development III)
/// </summary>
public class Subject : BaseEntity
{
    public string SubjectCode { get; set; } = string.Empty;
    public string SubjectName { get; set; } = string.Empty;

    public ICollection<TutorSubject> TutorSubjects { get; set; } = new List<TutorSubject>();
    public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}