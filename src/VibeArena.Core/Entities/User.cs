namespace VibeArena.Core.Entities;

/// <summary>
/// User entity - Người dùng
/// </summary>
public class User
{
    public int Id { get; set; }
    
    public string Username { get; set; } = null!;
    
    public string Email { get; set; } = null!;
    
    public string PasswordHash { get; set; } = null!;
    
    public string? FirstName { get; set; }
    
    public string? LastName { get; set; }
    
    public string? PhoneNumber { get; set; }
    
    public string Role { get; set; } = "Customer"; // Customer, Admin, Promoter
    
    public bool IsActive { get; set; } = true;
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    
    public byte[] RowVersion { get; set; } = null!;
}
