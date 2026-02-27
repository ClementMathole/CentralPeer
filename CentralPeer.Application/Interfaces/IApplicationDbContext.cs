using CentralPeer.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace CentralPeer.Application.Interfaces;
/// <summary>
/// Exposes the db tables to CQRS handlers without
/// exposing the postgres implimentation
/// </summary>
public interface IApplicationDbContext
{
    DbSet<Campus> Campuses { get; }
    DbSet<User> Users { get; }
    DbSet<TutorProfile> TutorProfiles { get; }
    DbSet<Subject> Subjects { get; }
    DbSet<TutorSubject> TutorSubjects { get; }
    DbSet<Booking> Bookings { get; }
    DbSet<ChatMessage> ChatMessages { get; }

    Task<int> SaveChangesAsync(CancellationToken ct);
}