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
            ViewBag.Categories = _context.Categories.ToList();
            return View("TaskForm", new ToDoTask()); // Ensure a new, empty task object is passed
        }




        [HttpPost]
        public IActionResult Add(ToDoTask taskToAdd)
        {
            Console.WriteLine($"Received CategoryId: {taskToAdd.CategoryId}");

            if (!ModelState.IsValid)
            {
                Console.WriteLine("Model state is invalid.");
        
                // Print all model state errors
                foreach (var key in ModelState.Keys)
                {
                    var errors = ModelState[key].Errors;
                    foreach (var error in errors)
                    {
                        Console.WriteLine($"Validation error in {key}: {error.ErrorMessage}");
                    }
                }

                ViewBag.Categories = _context.Categories.ToList();
                return View("TaskForm", taskToAdd);
            }

            _context.Tasks.Add(taskToAdd);
            _context.SaveChanges();
            return RedirectToAction("Quadrants");
        }




        /*
        
        I had to comment these out to get the program to work
        
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
        
        */
        
        [HttpGet]
        [HttpGet]
        public IActionResult Quadrants()
        {
            var tasks = _context.Tasks
                .Where(t => t.Completed == 0) // ✅ Only show incomplete tasks
                .ToList();

            return View(tasks);
        }
        
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var task = _context.Tasks.FirstOrDefault(t => t.TaskId == id);
            if (task == null)
            {
                return NotFound();
            }

            ViewBag.Categories = _context.Categories.ToList(); // Pass categories for dropdown
            return View("TaskForm", task);
        }

        [HttpPost]
        public IActionResult Edit(ToDoTask taskToEdit)
        {
            if (!_context.Categories.Any(c => c.CategoryId == taskToEdit.CategoryId))
            {
                ModelState.AddModelError("CategoryId", "Invalid Category selected.");
                ViewBag.Categories = _context.Categories.ToList();
                return View("TaskForm", taskToEdit);
            }

            _context.Tasks.Update(taskToEdit);
            _context.SaveChanges();
            return RedirectToAction("Quadrants");
        }


        [HttpPost]  // ✅ Ensure this is a POST request
        public IActionResult Delete(int id)
        {
            var taskToDelete = _context.Tasks.Find(id);
            if (taskToDelete != null)
            {
                _context.Tasks.Remove(taskToDelete);
                _context.SaveChanges();
            }
            return RedirectToAction("Quadrants");
        }

        [HttpPost]  // ✅ Ensure this is a POST request
        public IActionResult MarkComplete(int id)
        {
            var taskToComplete = _context.Tasks.Find(id);
            if (taskToComplete != null)
            {
                taskToComplete.Completed = 1;  // Mark as complete
                _context.SaveChanges();
            }
            return RedirectToAction("Quadrants");
        }



    }
}
