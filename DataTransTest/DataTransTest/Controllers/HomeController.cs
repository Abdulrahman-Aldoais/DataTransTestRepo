using DataTransTest.Domain.Entity;
using DataTransTest.DTOs;
using DataTransTest.Persistence.DataBase;
using Microsoft.AspNetCore.Mvc;




namespace DataTransTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<JsonResult> GetAllUser()
        {
            var users = _context.Users.ToList();
            if (users.Count > 0)
            {
                return Json(new { getInfo = users });
            }
            else
            {
                return Json(null);
            }
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(UserDTOs model)
        {
            if (ModelState.IsValid)
            {
                var existingUser = _context.Users.Where(u => u.Email.Equals(model.Email));

                if (existingUser != null)
                {
                    ModelState.AddModelError("Email", "هذا البريد الالكتروني موجود من قبل يرجى ادخال بريد اخر.");
                    return View(model);
                }
                return View(model);

            }
            var userModle = new User
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Phone = model.Phone,
                Address = model.Address,
                CreatedAt = DateTime.Now,

            };
            var user = _context.Users.Add(userModle);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Edit(int id)
        {
            var user = _context.Users.FirstOrDefault(n => n.Id.Equals(id));
            var userModle = new UserDTOs
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Phone = user.Phone,
                Address = user.Address

            };
            return View(userModle);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(UserDTOs model)
        {
            if (ModelState.IsValid)
            {
                var existingUser = _context.Users.FirstOrDefault(u => u.Email.Equals(model.Email) && u.Id != model.Id);

                if (existingUser != null)
                {
                    ModelState.AddModelError("Email", "هذا البريد الالكتروني موجود من قبل يرجى ادخال بريد اخر.");
                    return View(model);
                }
                var userModle = new User
                {
                    Id = model.Id,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    Phone = model.Phone,
                    Address = model.Address,
                    CreatedAt = DateTime.Now,
                };

                _context.Users.Update(userModle);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            return View(model);


        }

        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var getUser = _context.Users.FirstOrDefault(n => n.Id.Equals(id));
                var user = _context.Users.Remove(getUser);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));

            }
            catch (Exception ex)
            {
                return Json(new { error = "An error occurred while fetching user data" });
            }
        }



    }
}
