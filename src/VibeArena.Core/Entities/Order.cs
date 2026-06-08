namespace VibeArena.Core.Entities;

public class Order
{
    public int Id { get; set; }
    public string OrderNumber { get; set; } = null!;
    public int UserId { get; set; }
    public int EventId { get; set; }
    public string Status { get; set; } = "Pending";
    public decimal TotalAmount { get; set; }
    public int TotalTickets { get; set; }
    public string? ReservationId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? ConfirmedAt { get; set; }
    public byte[] RowVersion { get; set; } = null!;
}