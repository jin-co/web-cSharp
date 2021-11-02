using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList_Week9.Helpers
{
    public class TaskHelper
    {
        public static void AddNewTask(HttpContext httpContext)
        {
            List<string> taskNameList = new List<string>() { "Design", "Develop", "Test", "Release" };
            List<string> taskLengthList = new List<string>() { "Short", "Medium", "Long" };
            List<string> assignedToList = new List<string>() { "Randy", "Bob", "Jane", "Kyle", "Jack", "Jessica", "Lily", "Sophie" };
            List<int> priorityList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Random r = new Random();
            List<Models.Task> taskList = new List<Models.Task>();

            Models.Task newTask = new Models.Task()
            {
                TaskID = 1,
                TaskName = taskNameList[r.Next(0, 3)],
                TaskLength = taskLengthList[r.Next(0, 2)],
                AssignedTo = assignedToList[r.Next(0, 7)],
                Priority = priorityList[r.Next(0, 9)]
            };

            var taskListJSON = httpContext.Session.GetString("ToDoList");

            if (!String.IsNullOrEmpty(taskListJSON))
            {
                taskList = DeserializeTaskList(taskListJSON);
            }

            taskList.Add(newTask);

            SerializeTaskList(httpContext, taskList);
        }

        public static void SerializeTaskList(HttpContext httpContext, List<Models.Task> taskList)
        {
            httpContext.Session.SetString("ToDoList", JsonConvert.SerializeObject(taskList));
        }

        public static List<Models.Task> DeserializeTaskList(string json)
        {
            return JsonConvert.DeserializeObject<List<Models.Task>>(json);
        }

        public static void ClearTaskList(HttpContext httpContext)
        {
            //httpContext.Session.SetString("ToDoList", "");
            //httpContext.Session.Clear();
            httpContext.Session.Remove("ToDoList");
        }
    }
}
