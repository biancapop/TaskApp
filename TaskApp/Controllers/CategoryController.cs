using Microsoft.AspNetCore.Mvc;
using TaskApp.DatabaseContext;
using TaskApp.Models;

namespace TaskApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly TaskContext _taskContext;
        public CategoryController(TaskContext taskContext)
        {
            _taskContext = taskContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CategoryDto categoryDto)
        {
            if (!ModelState.IsValid)
            {
                return View(categoryDto);
            }

            Category category = new Category
            {
                Name = categoryDto.Name,
                Abbreviation = categoryDto.Abbreviation,
                Color = categoryDto.Color
            };

            _taskContext.Categories.Add(category);
            _taskContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
