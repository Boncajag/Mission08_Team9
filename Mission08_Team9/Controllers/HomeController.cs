using System.Diagnostics;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Mission08_Team9.Models;

namespace Mission08_Team9.Controllers
{
    public class HomeController : Controller
    {
        private TaskContext _context; // Declare model context object

        public HomeController(TaskContext TaskContext) // Constructor for model context object
        {
            _context = TaskContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var tasks = _context.Tasks.ToList();
            
            return View();
        }

        [HttpPost]
        public IActionResult Index(int id)
        {
            var tasks = _context.Tasks.ToList();

            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("TaskForm");
        }

        [HttpPost]
        public IActionResult Add(Task taskToAdd)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View("TaskForm");
        }

        [HttpPost]
        public IActionResult Edit(Task taskToEdit)
        {
            return View();
        }
    }
}
