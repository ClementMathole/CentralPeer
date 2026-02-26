using System;

namespace CentralPeer.Domain.Entities;
/// <summary>
/// Links tutor to the subjects they teach(many 2 many)
/// </summary>
public class TutorSubject
{
    public Guid TutorId { get; set; }
    public TutorProfile? Tutor { get; set; }
    
    public Guid SubjectId { get; set; }
    public Subject? Subject { get; set; }
}