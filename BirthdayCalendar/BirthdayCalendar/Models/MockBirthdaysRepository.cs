
using System.Linq;

namespace BirthdayCalendar.Models
{
    public class MockBirthdaysRepository : IBirthdayRepository
    {
        private DateTime today = new DateTime(2021, 12, 16);
        public IEnumerable<Birthday> GetAllBirthdays()
        {
            return new List<Birthday>
            {
                new Birthday {BirthdayId = 1, FirstName="Galin", LastName="Todorov", Date= new DateTime(1988, 12, 16) },
                new Birthday {BirthdayId = 2, FirstName="Vasil", LastName="Todorov", Date= new DateTime(2001, 8, 6) },
                new Birthday {BirthdayId = 3, FirstName="Ivan", LastName="Todorov", Date= new DateTime(1964, 4, 5) },
                new Birthday {BirthdayId = 4, FirstName="Antlaneta", LastName="Todorov", Date= new DateTime(1966, 12, 22) },
            };
        }

        public Birthday? GetBirthdayById(int id)
        {
            return GetAllBirthdays().FirstOrDefault(b => b.BirthdayId == id);
        }

        public IEnumerable<Birthday> GetTodayBirthdays()
        {
            return GetAllBirthdays().Where(b => today.Month == b.Date.Month &&
                                                today.Day == b.Date.Day);
        }

        public IEnumerable<Birthday> GetUpcomingBirthdays(int days)
        {
            return GetAllBirthdays()
                .Where(birthday =>
                {
                    DateTime nextBirthday = new DateTime(today.Year, birthday.Date.Month, birthday.Date.Day);

                    nextBirthday = nextBirthday.Date;
                    today = today.Date;

                    if (nextBirthday < today)
                    {
                        nextBirthday = nextBirthday.AddYears(1);  // Move the birthday to next year
                    }
                    TimeSpan daysUntilBirthday = nextBirthday - today;
                    
                    return days>=1 && days >= daysUntilBirthday.Days;
                }
                );
        }
    }
}
