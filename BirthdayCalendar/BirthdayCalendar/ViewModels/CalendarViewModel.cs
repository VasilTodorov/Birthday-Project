using System.Data;

namespace BirthdayCalendar.ViewModels
{
    public class CalendarViewModel
    {
        public IEnumerable<DateTime> Birthdays { get; init; }
        public DateTime Today { get; init; }

        public CalendarViewModel(IEnumerable<DateTime> birthdays, DateTime today)
        {
            Birthdays = birthdays;
            Today = today;
        }
    }
}
