using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList_Week9.Models.ViewModels
{
    public class HomeViewModel
    {
        public List<Task> TaskList { get; set; }

        public string LoggedInUser { get; set; }
    }
}
