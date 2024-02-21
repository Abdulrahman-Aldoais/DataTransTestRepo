using DataTransTest.Application.Repositories.CommentRepository;
using DataTransTest.Application.Repositories.EmployeeRepositoty;
using DataTransTest.Application.Repositories.PostRepository;
using DataTransTest.Application.Serveses.CommentService;
using DataTransTest.Application.Serveses.EmployeeServices;
using DataTransTest.Application.Serveses.PostService;
using DataTransTest.Middlewares;
using DataTransTest.Persistence;
using DataTransTest.Persistence.DataBase;
using DataTransTest.Persistence.Repositories.CommentRepository;
using DataTransTest.Persistence.Repositories.EmployeeRepository;
using DataTransTest.Persistence.Repositories.PostRepository;
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
builder.Services.AddScoped<IPostService, PostService>();
builder.Services.AddScoped<ICommentService, CommentService>();

builder.Services.AddScoped<IPostReadRepository, PostReadRepository>();
builder.Services.AddScoped<IPostWriteRepository, PostWriteRepository>();

builder.Services.AddScoped<ICommentReadRepository, CommentReadRepository>();
builder.Services.AddScoped<ICommentWriteRepository, CommentWriteRepository>();

builder.Services.AddScoped<IEmployeeReadRepositoty, EmployeeReadRepository>();
builder.Services.AddScoped<IEmployeeWriteRepositoty, EmployeeWriteRepository>();
//builder.Services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>();
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
