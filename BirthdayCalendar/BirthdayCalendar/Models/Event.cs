using System.ComponentModel.DataAnnotations;

namespace BirthdayCalendar.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; } // Primary Key
        public string GoogleEventId { get; set; } = string.Empty; // Google Calendar Event ID
        public string Summary { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string? Location { get; set; }
        public string? TimeZone { get; set; }
        public bool IsBirthday { get; set; }
        // Optional foreign key for the User who owns this event
        public int? UserId { get; set; }

        // Navigation Property
        public User? User { get; set; }

    }
}
