
namespace BirthdayCalendar.Models.Repositories
{
    public class UserRepository : IUserRepository
    {
        private BirthdayCalendarDbContext _birthdayCalendarDbContext;
        public UserRepository(BirthdayCalendarDbContext birthdayCalendarDbContext)
        {
            _birthdayCalendarDbContext = birthdayCalendarDbContext;
        }
        public IEnumerable<User> GetAllUsers()
        {
            return _birthdayCalendarDbContext.Users;
        }

        public User? GetUserById(int id)
        {
            return _birthdayCalendarDbContext.Users.FirstOrDefault(u=>u.UserId == id);
        }
    }
}
