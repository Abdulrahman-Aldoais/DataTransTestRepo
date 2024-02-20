using DataTransTest.Application.Repositories.EmployeeRepositoty;
using DataTransTest.Application.Serveses.EmployeeServices;
using DataTransTest.Middlewares;
using DataTransTest.Persistence;
using DataTransTest.Persistence.DataBase;
using DataTransTest.Persistence.Repositories.EmployeeRepository;
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

builder.Services.AddSingleton<DapperContext>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IEmployeeReadRepositoty, EmployeeReadRepository>();
builder.Services.AddScoped<IEmployeeWriteRepositoty, EmployeeWriteRepository>();

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
