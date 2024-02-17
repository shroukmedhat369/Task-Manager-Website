using Microsoft.AspNetCore.Mvc;
using MyTask.Data;
using MyTask.Models;

namespace MyTask.Controllers
{
    public class LoginController : Controller
    {
        private readonly OurDbContext _dbContext;

        public LoginController(OurDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(User user)
        {

            var existingUser = _dbContext.Users.FirstOrDefault(u => u.UserName == user.UserName && u.Password == user.Password);

            if (existingUser != null)
            {

                var userId = existingUser.Id;
                HttpContext.Session.SetInt32("UserId", userId);
                return RedirectToAction("Index", "Tasks");
            }


            ModelState.AddModelError("", "Invalid username or password");
            return View(user);
        }

    }
}
