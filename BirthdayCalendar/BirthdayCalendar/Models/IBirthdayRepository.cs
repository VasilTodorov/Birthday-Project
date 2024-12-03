namespace BirthdayCalendar.Models
{
    public interface IBirthdayRepository
    {
        /// <summary>
        /// From the database retrieves all birthday entries
        /// </summary>
        /// <returns>gets all Birthdays in the database</returns>
        IEnumerable<Birthday> GetAllBirthdays();
        /// <summary>
        /// Checks all Birthday.Date if it is in
        /// the next N "days" (excluding today) 
        /// </summary>
        /// <param name="days"></param>
        /// <returns>gets all Birthdays that will come in next N "days"</returns>
        IEnumerable<Birthday> GetUpcomingBirthdays(int days);
        /// <summary>
        /// Checks all Birthday.Date if it is today
        /// </summary>
        /// <returns>gets all Birthdays that are today</returns>
        IEnumerable<Birthday> GetTodayBirthdays();
        /// <summary>
        /// Searches for Birthday by id in the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Returns a Birthday by id</returns>
        Birthday? GetBirthdayById(int id);
    }
}
