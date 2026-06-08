namespace VibeArena.Core.Entities;

public class SeatHold
{
    public string Id { get; set; } = null!;
    public int EventId { get; set; }
    public int UserId { get; set; }
    public string SeatIds { get; set; } = null!;
    public DateTime ExpiresAt { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}