using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using GoalTask.Data.DataModel;
using GoalTask.Service;
using GoalTask.Data.Enums;
using System.Windows.Forms;

namespace GoalTask.Desktop
{
  public class UIHelper {

        public IGoalService GoalService { get; set; }
        public ICategoryService CategoryService { get; set; }
        public IStatusService StatusService { get; set; }
        public ITaskService TaskService { get; set; }
        public MainForm MainForm { get; set; }
        public UIHelper(MainForm mainForm)
        {
            GoalService = new GoalService();
            CategoryService = new CategoryService();
            StatusService = new StatusService();
            TaskService = new TaskService();
            MainForm = mainForm;
        }

        public void AddGoal()
        {
            if (MainForm.ValidateAddGoal())
            {
                GoalModel goalModel = new GoalModel()
                {
                    GoalId = 0,
                    GoalName = MainForm.GoalName,
                    GoalDesription = MainForm.GoalDescription,
                    GoalDeadline = MainForm.GoalDeadline,
                    GoalStatus = MainForm.GoalStatus,
                    Category = MainForm.Category

                };

                var succcess = GoalService.AddGoal(goalModel);
                if (succcess)
                {
                    MessageBox.Show(Resources.AddGoal_Success_Message,
                                    Resources.Success_Message_Title,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);   
                    ClearFieldsGoal();

                }

                else
                {
                    MessageBox.Show(Resources.AddGoal_Fail_Message,
                                    Resources.Fail_Message_Title, 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show(MainForm.ErrorMessage, Resources.AddGoal_Error_Message_Title,
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        

       public void ClearFieldsGoal()
        {
            MainForm.GoalName = string.Empty;
            MainForm.GoalDescription = string.Empty;
            MainForm.Category = 0;
            MainForm.GoalStatus = 0;
        }  

        public DataTable ViewCategory()
        {
            return CategoryService.ViewCategory();
        }

        public DataTable ViewStatus()
        {
            return StatusService.ViewStatus();
        }

        public DataTable ViewGoalName()
        {
            return GoalService.ViewGoalName();
        }

        public DataTable ViewAllGoals()
        {
            return GoalService.ViewAllGoals();
        }

        public DataRow ViewGoalById(int id)
        {
            return GoalService.ViewGoalById(id);
        }

        public void AddTask()
        {
            if (MainForm.ValidateAddTask())
            {
                TaskModel taskModel = new TaskModel()
                {
                    TaskID = 0,
                    TaskName = MainForm.TaskName,
                    TaskDescription = MainForm.TaskDescription,
                    TaskDeadline = MainForm.TaskDeadline,
                    Priority = (TaskPriority)MainForm.Priority,
                    TaskStatus = MainForm.TaskStatus,
                    GoalID = MainForm.SelectedGoalForTask,
                };

                var success = TaskService.AddTask(taskModel);
                if (success)
                {
                    MessageBox.Show(Resources.AddTask_Success_Message,
                                    Resources.Success_Message_Title,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    ClearFieldsTask();
                }
                else
                {
                    MessageBox.Show(Resources.AddTask_Fail_Message,
                                    Resources.Fail_Message_Title,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }

           }
           else
            {
                MessageBox.Show(MainForm.ErrorMessage, 
                                Resources.AddTask_Error_Message_Title,
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
            }
        }


        public void ClearFieldsTask()
        {
            MainForm.TaskName = String.Empty;
            MainForm.TaskDescription = String.Empty;
            MainForm.SelectedGoalForTask = 0;
            MainForm.TaskStatus = 0;
           
        }
        public DataTable FilterGoals()
        {
                int categoryID = MainForm.CategoryFilter;
                int statusID = MainForm.GStatusFilter;
                DateTime? from = MainForm.DeadlineFilterFrom;
                DateTime? to = MainForm.DeadlineFilterTo;
                return GoalService.FilterGoals(categoryID, statusID, from, to);
        }

        public void UpdateGoal()
        {
            GoalModel goalModel = new GoalModel()
            {
                GoalId = MainForm.goalID,
                GoalName= MainForm.GoalNameNew,
                GoalDesription= MainForm.GoalDescriptionNew,
                GoalStatus = MainForm.GoalStatusNew,
                Category= MainForm.CategoryNew

            };

            var flag= GoalService.UpdateGoal(goalModel);

            if (flag)
            {
                MessageBox.Show(Resources.UpdateGoal_Success_Message,
                                 Resources.Success_Message_Title,
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);

                DataTable data = GoalService.ViewAllGoals();
                MainForm.LoadDataGridViewGoals(data);

            }

            else
            {
                MessageBox.Show(Resources.UpdateGoal_Fail_Message,
                                Resources.Fail_Message_Title,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }

        public void DeleteGoal()
        {
            bool success = false;
            bool confirm = ConfirmDelete();
            if (confirm)
            {
                success = GoalService.DeleteGoal(MainForm.goalID);
            }
            if (success)
            {
                MessageBox.Show(Resources.DeleteGoal_Success_Message,
                                Resources.Success_Message_Title,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                DataTable data = GoalService.ViewAllGoals();
                MainForm.LoadDataGridViewGoals(data);

            }

            else if(confirm) {
                MessageBox.Show(Resources.DeleteGoal_Fail_Message,
                                Resources.Fail_Message_Title,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        public DataTable ViewallTasks()
        {
            return TaskService.ViewAllTasks();
        }

        public DataTable FilterTasks()
        {
            int goalID = MainForm.GoalForTaskFilter;
            int taskStatus = MainForm.TaskStatusFilter;
            DateTime? from = MainForm.TaskDeadlineFilterFrom;
            DateTime? to = MainForm.TaskDeadlineFilterTo;
            return TaskService.FilterTasks(goalID, taskStatus, from, to);
        }

        public DataRow ViewTaskByID(int id)
        {
            return TaskService.ViewTaskByID(id);
        }

        public void UpdateTask()
        {
            TaskModel task = new TaskModel()
            {
                TaskName=MainForm.TaskNameNew,
                TaskDescription=MainForm.TaskDescriptionNew,
                TaskStatus=MainForm.TaskStatusNew,
                Priority=(TaskPriority)MainForm.PriorityNew,
                TaskID=MainForm.taskID

            };

            var flag = TaskService.UpdateTask(task);

            if (flag)
            {
                MessageBox.Show(Resources.UpdateTask_Success_Message,
                                Resources.Success_Message_Title,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                DataTable data = TaskService.ViewAllTasks();
                MainForm.LoadDataGridViewTasks(data);

            }

            else
            {
                MessageBox.Show(Resources.UpdateTask_Fail_Message,
                                Resources.Fail_Message_Title,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }


        }

        public void DeleteTask()
        {
            bool success = false;
            bool confirm = ConfirmDelete();
            if (confirm)
            {
                success = TaskService.DeleteTask(MainForm.taskID);
            }
            if (success)
            {
                MessageBox.Show(Resources.DeleteTask_Success_Message,
                                Resources.Success_Message_Title,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                DataTable data = TaskService.ViewAllTasks();
                MainForm.LoadDataGridViewTasks(data);

            }

            else if (confirm)
            {
                MessageBox.Show(Resources.DeleteTask_Fail_Message,
                                Resources.Fail_Message_Title,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        
        public void CloseTask()
        {
            bool success = TaskService.CloseTask(DateTime.Now, MainForm.taskID);
            if (success)
            {
                MessageBox.Show(Resources.CloseTask_Success_Message,
                                Resources.Success_Message_Title,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                DataTable data = TaskService.ViewAllTasks();
                MainForm.LoadDataGridViewTasks(data);
            }
            else
                MessageBox.Show(Resources.CloseTask_Fail_Message,
                                Resources.Fail_Message_Title,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
        }

        public bool ConfirmDelete()
        {
            DialogResult confirmation;
            confirmation = MessageBox.Show(Resources.Delete_Confirmation,
                                           Resources.Delete_Confirmation_Title,
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Warning);

            if(confirmation == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void AddErrorMessage(string error)
        {
            if (MainForm.ErrorMessage == string.Empty)
            {
                MainForm.ErrorMessage = Resources.Error_Message_Header + "\n\n";
            }
            MainForm.ErrorMessage += error + "\n";
        }

      public void ShowErrorMessage(Exception ex)
      {
          MessageBox.Show(ex.Message,
              Resources.System_Error_Message_Title,
              MessageBoxButtons.OK,
              MessageBoxIcon.Error);

      }


    }
}
