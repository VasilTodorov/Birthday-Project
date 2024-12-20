namespace BirthdayCalendar.Models
{
    public class Event
    {
        public int EventId { get; set; } // Primary Key
        public string GoogleEventId { get; set; } = string.Empty; // Google Calendar Event ID
        public string Summary { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string? Location { get; set; }
        public string? TimeZone { get; set; }        
    }
}
