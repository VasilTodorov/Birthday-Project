using BirthdayCalendar.Models;
using BirthdayCalendar.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BirthdayCalendar.Controllers
{
    public class BirthdayController : Controller
    {
        private IBirthdayRepository _birthdayRepository;

        public BirthdayController(IBirthdayRepository birthdayRepository)
        {
            _birthdayRepository = birthdayRepository;
        }

        public IActionResult Calendar()
        {
            return View(new CalendarViewModel(_birthdayRepository
                                                .GetAllBirthdays()
                                                .Select(b=>b.Date), DateTime.Today));
        }
    }
}
