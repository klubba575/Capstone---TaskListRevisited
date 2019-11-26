using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskListRevisited.Models;

namespace TaskListRevisited.Controllers
{
	
    public class TaskListController : Controller
    {
		private readonly TaskListContext _context;

		public TaskListController(TaskListContext context)
		{
			_context = context;
		}
		public IActionResult Index()
        {
            return View();
        }
		public IActionResult ListTasks()
		{
			var listofTasks = _context.Tasks.ToList();
			return View(listofTasks);
		}
		[HttpGet]
		public IActionResult AddNewTask()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddNewTask(Tasks newtask)
		{
			if(ModelState.IsValid)
			{
				_context.Tasks.Add(newtask);
				_context.SaveChanges();
			}
			return RedirectToAction("Index");
		}
    }
}