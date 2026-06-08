namespace VibeArena.Core.Entities;

/// <summary>
/// Venue entity - Địa điểm tổ chức
/// </summary>
public class Venue
{
    public int Id { get; set; }
    
    public string Name { get; set; } = null!;
    
    public string Address { get; set; } = null!;
    
    public string City { get; set; } = null!;
    
    public int Capacity { get; set; }
    
    public string? Description { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    
    public byte[] RowVersion { get; set; } = null!;
}
