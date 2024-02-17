using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyTask.Data;
using MyTask.Models;

namespace MyTask.Controllers
{
    public class RegisterController : Controller
    {
        private readonly OurDbContext _dbContext;

        public RegisterController(OurDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User newUser)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Users.Add(newUser);
                _dbContext.SaveChanges();
                return RedirectToAction("Index","Login");
            }

            return View(newUser);
        }
    }
}
