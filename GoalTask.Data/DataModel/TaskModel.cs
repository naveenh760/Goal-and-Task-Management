using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoalTask.Data.Enums;


namespace GoalTask.Data.DataModel
{
   public class TaskModel
    {
        public int TaskID { get; set; }
        public String TaskName { get; set; }
        public String TaskDescription { get; set; }
        public TaskPriority Priority { get; set; }
        public DateTime TaskDeadline { get; set; }
        public int TaskStatus { get; set; }
        public int GoalID { get; set; }
    }
}
