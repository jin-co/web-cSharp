using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoList_Week9.Helpers;
using ToDoList_Week9.Models.ViewModels;

namespace ToDoList_Week9.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            var toDoTaskListJSON = HttpContext.Session.GetString("ToDoList");
            var toDoTaskListDeserialized = new List<Models.Task>();

            if (!String.IsNullOrEmpty(toDoTaskListJSON))
            {
                toDoTaskListDeserialized = TaskHelper.DeserializeTaskList(toDoTaskListJSON);
            }

            HomeViewModel homeViewModel = new HomeViewModel()
            {
                TaskList = toDoTaskListDeserialized,
                LoggedInUser = "Randy Daigle"
            };

            return View(homeViewModel);
        }

        public IActionResult AddNewRandomTask()
        {
            TaskHelper.AddNewTask(HttpContext);

            return RedirectToAction("Index");
        }

        public IActionResult ClearTaskList()
        {
            TaskHelper.ClearTaskList(HttpContext);

            return RedirectToAction("Index");
        }
    }
}
