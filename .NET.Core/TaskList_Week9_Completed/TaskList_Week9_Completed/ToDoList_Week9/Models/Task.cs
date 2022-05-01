using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList_Week9.Models
{
    public class Task
    {
        public int TaskID { get; set; }

        public string TaskName { get; set; }

        public string TaskLength { get; set; }

        public string AssignedTo { get; set; }

        public bool IsCompleted { get; set; }

        public int Priority { get; set; }
    }
}
