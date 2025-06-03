using Microsoft.AspNetCore.Mvc;
using NTierTodoApp.Business;

namespace NTierTodoApp.Controllers
{
    public class TaskController : Controller
    {
        private readonly TaskService service;

        public TaskController(TaskService taskService)
        {
            service = taskService;
        }

        public IActionResult Index()
        {
            var tasks = service.GetTasks();
            return View(tasks);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            service.DeleteTask(id);
            return RedirectToAction("Index");
        }
    }
}
