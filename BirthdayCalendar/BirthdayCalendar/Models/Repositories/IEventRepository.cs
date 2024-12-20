namespace BirthdayCalendar.Models.Repositories
{
    public interface IEventRepository
    {
        IEnumerable<Event> GetAllEvents();
        IEnumerable<Event> GetAllBirthdayEvents();
        Event? GetEventById(int id);
    }
}
