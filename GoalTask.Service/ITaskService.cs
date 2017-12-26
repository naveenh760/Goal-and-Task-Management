using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using GoalTask.Data.DataModel;
using GoalTask.Data.DataAccess;

namespace GoalTask.Service
{
   public interface ITaskService
    {
        bool AddTask(TaskModel taskModel);
        DataTable ViewAllTasks();
        DataTable FilterTasks(int goal, int taskStatus, DateTime? startDate, DateTime? endDate);
        DataRow ViewTaskByID(int id);
        bool UpdateTask(TaskModel task);
        bool DeleteTask(int id);
        bool CloseTask(DateTime closingDate, int taskID);

    }
}
