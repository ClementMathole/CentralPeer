using CentralPeer.Application.Interfaces;
using CentralPeer.Domain.Common;
using CentralPeer.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CentralPeer.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    private readonly ICurrentUser _currentUser;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, ICurrentUser currentUser) : base(options)
    {
        _currentUser = currentUser;
    }

    // Database tables
    public DbSet<Campus> Campuses { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<TutorProfile> TutorProfiles { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<TutorSubject> TutorSubjects { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<ChatMessage> ChatMessages { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // 1 - 1 relationship between User and TutorProfile
        modelBuilder.Entity<User>()
            .HasOne(u => u.TutorProfile)
            .WithOne(tp => tp.User)
            .HasForeignKey<TutorProfile>(tp => tp.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        // Many - Many relationship between Tutors and Subjects
        modelBuilder.Entity<TutorSubject>()
            .HasKey(ts => new { ts.TutorId, ts.SubjectId });

        modelBuilder.Entity<TutorSubject>()
            .HasOne(ts => ts.Tutor)
            .WithMany(tp => tp.TutorSubjects)
            .HasForeignKey(ts => ts.TutorId);

        modelBuilder.Entity<TutorSubject>()
            .HasOne(ts => ts.Subject)
            .WithMany(s => s.TutorSubjects)
            .HasForeignKey(ts => ts.SubjectId);

        // Chat message relationships to prevent cascade loops
        modelBuilder.Entity<ChatMessage>()
            .HasOne(m => m.Sender)
            .WithMany(u => u.SentMessages)
            .HasForeignKey(m => m.SenderId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<ChatMessage>()
            .HasOne(m => m.Receiver)
            .WithMany(u => u.ReceivedMessages)
            .HasForeignKey(m => m.ReceiverId)
            .OnDelete(DeleteBehavior.Restrict);
        
        // Global Query Filters
        // automatically filters data so users only interact with data from their campus
        modelBuilder.Entity<User>()
            .HasQueryFilter(u => !_currentUser.CampusId.HasValue || u.CampusId == _currentUser.CampusId);
    }

    /// <summary>
    /// Automatically handles timestamps before commiting changes to the database
    /// </summary>
    public override Task<int> SaveChangesAsync(CancellationToken ct = new CancellationToken())
    {
        foreach (var entry in ChangeTracker.Entries<BaseEntity>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedAt = DateTime.UtcNow;
                    break;
                case EntityState.Modified:
                    entry.Entity.UpdatedAt = DateTime.UtcNow;
                    break;
                //default:
            }
        }

        return base.SaveChangesAsync(ct);
    }
}