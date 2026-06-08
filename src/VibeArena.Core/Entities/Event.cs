namespace VibeArena.Core.Entities;

/// <summary>
/// Event entity - Sự kiện concert
/// </summary>
public class Event
{
    public int Id { get; set; }
    
    public string Title { get; set; } = null!;
    
    public string? Description { get; set; }
    
    public int VenueId { get; set; }
    
    public string Performer { get; set; } = null!;
    
    public DateTime EventDate { get; set; }
    
    public DateTime? EventEndDate { get; set; }
    
    public string Status { get; set; } = "Upcoming"; // Upcoming, Ongoing, Completed, Cancelled
    
    public int TotalTickets { get; set; }
    
    public int AvailableTickets { get; set; }
    
    public decimal Price { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    
    public int CreatedById { get; set; }
    
    public byte[] RowVersion { get; set; } = null!;
}
