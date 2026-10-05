using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Monolith.Schedule.Models;
using System.Diagnostics;

namespace Monolith.Schedule.Controllers
{
    public class HomeController : Controller
    {
        //private readonly MyDbContext _context2;
        //public HomeController(MyDbContext context)
        //{
        //    _context2 = context;
        //}
        private readonly MyIdentityDbContext _context;
        public HomeController(MyIdentityDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            //_context.Tasks.Add(new MyTask { Subject = "Test Task", Expiration = DateTime.Now.AddDays(1) });
            //_context.SaveChanges();
            return View();
        }
        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
