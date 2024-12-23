namespace BirthdayCalendar.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string? LastName { get; set; }
        public string? EmailAddress { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime Birthday { get; set; }
        // Foreign Key for Birthday Event
        //public int? BirthdayEventId { get; set; }

        // Navigation Property
        public List<Event>? Events { get; set; } = default!;
    }
}
