namespace BirthdayCalendar.Models
{
    public class Birthday
    {
        public int BirthdayId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime Date { get; set; }
    }
}
