namespace BirthdayCalendar.Models.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();
        User? GetUserById(int id);
    }
}
