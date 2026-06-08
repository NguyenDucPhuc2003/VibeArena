using Microsoft.EntityFrameworkCore;
using VibeArena.Core.Entities;

namespace VibeArena.Infrastructure.Data;

public class VibeArenaDbContext : DbContext
{
    public VibeArenaDbContext(DbContextOptions<VibeArenaDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Venue> Venues { get; set; } = null!;
    public DbSet<Event> Events { get; set; } = null!;
    public DbSet<Seat> Seats { get; set; } = null!;
    public DbSet<SeatHold> SeatHolds { get; set; } = null!;
    public DbSet<Order> Orders { get; set; } = null!;
    public DbSet<OrderDetail> OrderDetails { get; set; } = null!;
    public DbSet<Payment> Payments { get; set; } = null!;
    public DbSet<Notification> Notifications { get; set; } = null!;
    public DbSet<AuditLog> AuditLogs { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Users
        modelBuilder.Entity<User>(e => {
            e.HasKey(x => x.Id);
            e.Property(x => x.Username).HasMaxLength(100).IsRequired();
            e.Property(x => x.Email).HasMaxLength(255).IsRequired();
            e.Property(x => x.RowVersion).IsRowVersion();
            e.HasIndex(x => x.Username).IsUnique();
            e.HasIndex(x => x.Email).IsUnique();
        });

        // Venues
        modelBuilder.Entity<Venue>(e => {
            e.HasKey(x => x.Id);
            e.Property(x => x.Name).HasMaxLength(200).IsRequired();
            e.Property(x => x.RowVersion).IsRowVersion();
        });

        // Events
        modelBuilder.Entity<Event>(e => {
            e.HasKey(x => x.Id);
            e.Property(x => x.Title).HasMaxLength(300).IsRequired();
            e.Property(x => x.Price).HasPrecision(10, 2);
            e.Property(x => x.RowVersion).IsRowVersion();
            e.HasIndex(x => x.Status);
            e.HasIndex(x => x.EventDate);
        });

        // Seats
        modelBuilder.Entity<Seat>(e => {
            e.HasKey(x => x.Id);
            e.Property(x => x.Price).HasPrecision(10, 2);
            e.Property(x => x.RowVersion).IsRowVersion();
            e.HasIndex(x => new { x.EventId, x.SeatNumber }).IsUnique();
            e.HasIndex(x => new { x.EventId, x.Status });
        });

        // SeatHolds
        modelBuilder.Entity<SeatHold>(e => {
            e.HasKey(x => x.Id);
            e.HasIndex(x => x.ExpiresAt);
        });

        // Orders
        modelBuilder.Entity<Order>(e => {
            e.HasKey(x => x.Id);
            e.Property(x => x.TotalAmount).HasPrecision(10, 2);
            e.Property(x => x.RowVersion).IsRowVersion();
            e.HasIndex(x => x.OrderNumber).IsUnique();
            e.HasIndex(x => x.UserId);
            e.HasIndex(x => x.Status);
        });

        // OrderDetails
        modelBuilder.Entity<OrderDetail>(e => {
            e.HasKey(x => x.Id);
            e.Property(x => x.Price).HasPrecision(10, 2);
            e.HasIndex(x => x.OrderId);
        });

        // Payments
        modelBuilder.Entity<Payment>(e => {
            e.HasKey(x => x.Id);
            e.Property(x => x.Amount).HasPrecision(10, 2);
            e.HasIndex(x => x.TransactionId).IsUnique();
            e.HasIndex(x => x.Status);
        });

        // Notifications
        modelBuilder.Entity<Notification>(e => {
            e.HasKey(x => x.Id);
            e.HasIndex(x => x.UserId);
        });
    }
}