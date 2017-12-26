using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using GoalTask.Data.DataAccess;
using GoalTask.Data.DataModel;

namespace GoalTask.Service
{
    public class TaskService:ITaskService
    {
        public ITaskAccess TaskAccess { get; set; }
        public IGoalAccess GoalAccess { get; set; }
        public TaskService()
        {
            this.TaskAccess = new TaskAccess();
            this.GoalAccess = new GoalAccess();
        }
        public bool AddTask(TaskModel taskModel)
        {
            return TaskAccess.AddTask(taskModel);

        } 

        public DataTable ViewAllTasks()
        {
            return TaskAccess.ViewAllTasks();
        }

        public DataTable FilterTasks(int goal, int taskStatus, DateTime? startDate, DateTime? endDate)
        {
            object goalN, taskStatusN, startDateN, endDateN;
            if (startDate == null)
            {
                startDateN = DBNull.Value;
            }

            else
            {
                startDateN = startDate;
            }


            if (endDate == null)
            {
                endDateN = DBNull.Value;
            }
            else
            {
                endDateN = endDate;
            }

            if (goal == -1)
            {
                goalN = DBNull.Value;
            }
            else
            {
                goalN = goal;
            }

            if (taskStatus == -1)
            {
                taskStatusN = DBNull.Value;
            }
            else
            {
                taskStatusN = taskStatus;
            }

            return TaskAccess.FilterTasks(goalN, taskStatusN, startDateN, endDateN);
        }

        public DataRow ViewTaskByID(int id)
        {
            return TaskAccess.ViewTaskByID(id);
        }

        public bool UpdateTask(TaskModel task)
        {
            return TaskAccess.UpdateTask(task);
        }

        public bool DeleteTask(int id)
        {
            return TaskAccess.DeleteTask(id);
        }

        public bool CloseTask(DateTime closingDate,int taskID)
        {
            bool result = TaskAccess.CloseTask(closingDate, taskID);
            if (result == true)
            {
                int goalID = TaskAccess.GetGoalIDOfTask(taskID);

                if (goalID != 0)
                {
                    int totalTasks = TaskAccess.CountTasksInGoal(goalID);
                    int completedTasks = TaskAccess.CountCompletedTasksInGoal(goalID);
                    if(totalTasks - completedTasks == 0)
                    {
                        GoalAccess.CloseGoal(DateTime.Now, goalID);
                    }
                }
            }

            return result;

            
            
        }
    }  
}
