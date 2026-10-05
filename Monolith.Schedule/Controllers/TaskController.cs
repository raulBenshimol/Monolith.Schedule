using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Monolith.Schedule.Data;
using Monolith.Schedule.Models;

namespace Monolith.Schedule.Controllers
{
    [Authorize]
    public class TaskController : Controller
    {
        private readonly MyDbContext _dbcontext;
        public TaskController(MyDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        // GET: TaskController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TaskController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateTaskRequest request)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    _dbcontext.Add(new MyTask
                    {
                        Subject = request.Contenido,
                        Expiration = DateTime.UtcNow
                    });
                    _dbcontext.SaveChanges();
                    return RedirectToAction(nameof(Create), "Task");
                }
                return View(request);
            }
            catch
            {
                return View();
            }
        }
    }
}
