using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using GoalTask.Data.DataModel;

namespace GoalTask.Data.DataAccess
{
   public interface ITaskAccess
    {
        bool AddTask(TaskModel taskModel);
        DataTable ViewAllTasks();
        DataTable FilterTasks(object goal, object taskStatus, object startDate, object endDate);
        DataRow ViewTaskByID(int id);
        bool UpdateTask(TaskModel task);
        bool DeleteTask(int id);
        bool CloseTask(DateTime closingDate, int taskID);
        int CountCompletedTasksInGoal(int goalID);
        int CountTasksInGoal(int goalID);
        int GetGoalIDOfTask(int taskID);
    } 
}
