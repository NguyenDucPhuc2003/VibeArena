namespace VibeArena.Core.Entities;

/// <summary>
/// Seat entity - Ghế ngồi
/// </summary>
public class Seat
{
    public int Id { get; set; }
    
    public int EventId { get; set; }
    
    public string SeatNumber { get; set; } = null!; // A1, A2, B1, v.v.
    
    public string Row { get; set; } = null!; // A, B, C, v.v.
    
    public int SeatColumn { get; set; }
    
    public string SeatType { get; set; } = "Standard"; // Standard, VIP, Premium
    
    public decimal Price { get; set; }
    
    public string Status { get; set; } = "Available"; // Available, OnHold, Sold, Blocked
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    
    public byte[] RowVersion { get; set; } = null!;
}
