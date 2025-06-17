namespace SIMS_dotNet.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Role { get; set; } // e.g., "Admin", "User", etc.
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Store { get; set; } // e.g., "Alvarado", "Piedras negras", etc.
        public DateTime BirthDate { get; set; } = DateTime.Now;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        
    }
}
