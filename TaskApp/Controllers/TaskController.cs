using Microsoft.AspNetCore.Mvc;
using TaskApp.DatabaseContext;
using TaskApp.Models;

namespace TaskApp.Controllers
{
    public class TaskController : Controller
    {
        private readonly TaskContext _taskContext;
        public TaskController(TaskContext taskContext)
        {
            _taskContext = taskContext;
        }

        public IActionResult Index()
        {
            List<Models.MyTask> tasks = _taskContext.Tasks.ToList();
            return View(tasks);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(MyTask task)
        {
            if (ModelState.IsValid)
            {
                _taskContext.Tasks.Add(task);
                _taskContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(task);
        }
    }
}
