using DataTransTest.Middlewares;
using DataTransTest.Persistence.DataBase;
using DataTransTest.Serveses;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<TimeService>();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    string connectionString = builder.Configuration.GetConnectionString(name: "Connection");
    options.UseSqlServer(connectionString);
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseMiddleware<StatsMiddleware>();
// app.Use((context, next) =>
// {
//     DateTime requestTime = DateTime.Now;
//     var resulte = next(context);
//     DateTime responseTime = DateTime.Now;

//     TimeSpan processDuration = requestTime - responseTime;
//     Console.WriteLine("[inline Midelware] process duration =" + processDuration.TotalMilliseconds + "ms");

//     return resulte;
// });

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
