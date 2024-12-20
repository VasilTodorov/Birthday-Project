using BirthdayCalendar.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<BirthdayCalendarDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString
    ("BethanysPieShopDbContextConnection")));
//builder.Services.AddScoped<IBirthdayRepository, MockBirthdayRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

// Not needed but by conventions will be left!!
app.UseRouting(); 

//app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
