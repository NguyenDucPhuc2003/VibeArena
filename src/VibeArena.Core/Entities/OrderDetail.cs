namespace VibeArena.Core.Entities;

public class OrderDetail
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int SeatId { get; set; }
    public string SeatNumber { get; set; } = null!;
    public decimal Price { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}