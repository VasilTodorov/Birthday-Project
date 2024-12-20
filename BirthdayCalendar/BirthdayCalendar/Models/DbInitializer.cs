namespace BirthdayCalendar.Models
{
    public static class DbInitializer
    {
        public static void Seed(BirthdayCalendarDbContext context)
        {
            if (!context.Events.Any())
            {
                context.Events.AddRange
                (
                    new Event
                    {
                        Summary = "Sport",
                        GoogleEventId = "random3245897824number",
                        IsBirthday = false,
                        StartTime = new DateTime(2024, 12, 24),
                        EndTime = new DateTime(2025, 12, 25)
                    },
                    new Event
                    {
                        Summary = "AE lecture",
                        GoogleEventId = "random3245897824number",
                        IsBirthday = false,
                        StartTime = new DateTime(2024, 12, 27),
                        EndTime = new DateTime(2025, 12, 28)
                    }
                );

                context.SaveChanges();
            }
            if (!context.Users.Any())
            {
                context.Users.AddRange
                (
                    new User
                    {
                        FirstName = "Vasil",
                        LastName = "Todorov",
                        Birthday = new DateTime(2001, 8, 6),
                        BirthdayEvent = new Event
                        {
                            Summary = "Vasil Birthday",
                            GoogleEventId = "random3245897824number",
                            IsBirthday = true,
                            StartTime = new DateTime(2025, 8, 6),
                            EndTime = new DateTime(2025, 8, 6)
                        }
                    },
                    new User
                    {
                        FirstName = "Galin",
                        LastName = "Todorov",
                        Birthday = new DateTime(1988, 12, 26),
                        BirthdayEvent = new Event
                        {
                            Summary = "Vasil Birthday",
                            GoogleEventId = "random3245897824number",
                            IsBirthday = true,
                            StartTime = new DateTime(2024, 12, 26),
                            EndTime = new DateTime(2024, 12, 27)
                        }
                    },
                    new User
                    {
                        FirstName = "Antlaneta",
                        LastName = "Todorov",
                        Birthday = new DateTime(1964, 12, 23),
                        BirthdayEvent = new Event
                        {
                            Summary = "Vasil Birthday",
                            GoogleEventId = "random3245897824number",
                            IsBirthday = true,
                            StartTime = new DateTime(2024, 12, 24),
                            EndTime = new DateTime(2024, 12, 23)
                        }
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
