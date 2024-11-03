namespace WebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            //ghg
            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
