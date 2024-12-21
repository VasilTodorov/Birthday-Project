
namespace BirthdayCalendar.Models.Repositories
{
    public class EventRepository : IEventRepository
    {
        private BirthdayCalendarDbContext _birthdayCalendarDbContext;

        public EventRepository(BirthdayCalendarDbContext birthdayCalendarDbContext)
        {
            _birthdayCalendarDbContext = birthdayCalendarDbContext;
        }

        public IEnumerable<Event> GetAllBirthdayEvents()
        {
            return _birthdayCalendarDbContext.Events.Where(e=>e.IsBirthday);
        }

        public IEnumerable<Event> GetAllEvents()
        {
            return _birthdayCalendarDbContext.Events;
        }

        public Event? GetEventById(int id)
        {
            return _birthdayCalendarDbContext.Events.FirstOrDefault(e => e.EventId == id);
        }
    }
}
