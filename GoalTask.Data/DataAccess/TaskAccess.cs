using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoalTask.Data.DataModel;
using System.Data;
using System.Data.OleDb;

namespace GoalTask.Data.DataAccess
{
   public class TaskAccess:ConnectionAccess,ITaskAccess
    {
        public bool AddTask(TaskModel taskModel)
        {
            var rowsAffected = 0;
            OleDbConnection conn = GetNewDBConnection();
            OleDbCommand oleDbCommand;
            if (taskModel.GoalID==0)
            {
                oleDbCommand = new OleDbCommand("qInsertTask", conn);
            }
            else
            {
                oleDbCommand = new OleDbCommand("qInsertTaskWithGoal", conn);

            }
            
            oleDbCommand.CommandType = CommandType.StoredProcedure;

            oleDbCommand.Parameters.AddWithValue("@TaskName", taskModel.TaskName);
            oleDbCommand.Parameters.AddWithValue("@TaskDescription", taskModel.TaskDescription);
            oleDbCommand.Parameters.AddWithValue("@Priority", taskModel.Priority);
            oleDbCommand.Parameters.AddWithValue("@TaskDeadline", taskModel.TaskDeadline.ToShortDateString());
            oleDbCommand.Parameters.AddWithValue("@TaskStatus", taskModel.TaskStatus);
            oleDbCommand.Parameters.AddWithValue("@GoalID", taskModel.GoalID);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            rowsAffected = oleDbCommand.ExecuteNonQuery();
            conn.Close();

            return rowsAffected > 0;

        }

        public DataTable ViewAllTasks()
        {
            DataTable dataTable = new DataTable();
            using (OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter())
            {
                oleDbDataAdapter.SelectCommand = new OleDbCommand("qViewAllTasks");
                oleDbDataAdapter.SelectCommand.Connection = GetNewDBConnection();
                oleDbDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                oleDbDataAdapter.Fill(dataTable);
            }
            return dataTable;
        }

        public DataTable FilterTasks(object goal,object taskStatus,object startDate,object endDate)
        {
            DataTable data = new DataTable();
            using (OleDbDataAdapter oleDbDataAdpater = new OleDbDataAdapter())
            {
                oleDbDataAdpater.SelectCommand = new OleDbCommand("qFilterTasks");
                oleDbDataAdpater.SelectCommand.Connection = GetNewDBConnection();
                oleDbDataAdpater.SelectCommand.CommandType = CommandType.StoredProcedure;
                oleDbDataAdpater.SelectCommand.Parameters.AddWithValue("@startDate", startDate);
                oleDbDataAdpater.SelectCommand.Parameters.AddWithValue("@endDate", endDate);
                oleDbDataAdpater.SelectCommand.Parameters.AddWithValue("@taskStatus", taskStatus);
                oleDbDataAdpater.SelectCommand.Parameters.AddWithValue("@goalID", goal);
                oleDbDataAdpater.Fill(data);
            }
            return data;
        }

        public DataRow ViewTaskByID(int id)
        {
            DataTable dataTable = new DataTable();
            DataRow dataRow;
            using (OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter())
            {
                oleDbDataAdapter.SelectCommand = new OleDbCommand("qViewTaskById");
                oleDbDataAdapter.SelectCommand.Connection = GetNewDBConnection();
                oleDbDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                oleDbDataAdapter.SelectCommand.Parameters.AddWithValue("@taskID", id);
                oleDbDataAdapter.Fill(dataTable);
            }

            dataRow = dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;
            return dataRow;
        }


        public bool UpdateTask(TaskModel task)
        {
            var rowsAffected = 0;
            OleDbConnection conn = GetNewDBConnection();
            OleDbCommand oleDbCommand = new OleDbCommand("qUpdateTask", conn);
            oleDbCommand.CommandType = CommandType.StoredProcedure;
            
            oleDbCommand.Parameters.AddWithValue("@taskName", task.TaskName);
            oleDbCommand.Parameters.AddWithValue("@taskDescription", task.TaskDescription);
            oleDbCommand.Parameters.AddWithValue("@priority", task.Priority);
            oleDbCommand.Parameters.AddWithValue("@taskStatus", task.TaskStatus);
            oleDbCommand.Parameters.AddWithValue("@taskID", task.TaskID);

            //open the connection, execute the query and close the connection
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            rowsAffected = oleDbCommand.ExecuteNonQuery();
            conn.Close();
            return rowsAffected > 0;
        }

        public bool DeleteTask(int id)
        {
            var rowsAffected = 0;
            OleDbConnection conn = GetNewDBConnection();
            OleDbCommand oleDbCommand = new OleDbCommand("qDeleteTask", conn);
            oleDbCommand.CommandType = CommandType.StoredProcedure;

            oleDbCommand.Parameters.AddWithValue("@taskID", id);

            //open the connection, execute the query and close the connection
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            rowsAffected = oleDbCommand.ExecuteNonQuery();
            conn.Close();
            return rowsAffected > 0;

           
        }

        public bool CloseTask(DateTime closingDate,int taskID)
        {
            var rowsAffected = 0;
            OleDbConnection conn = GetNewDBConnection();
            OleDbCommand oleDbCommand = new OleDbCommand("qCloseTask", conn);
            oleDbCommand.CommandType = CommandType.StoredProcedure;

            oleDbCommand.Parameters.AddWithValue("@taskClosingDate", closingDate.ToShortDateString());
            oleDbCommand.Parameters.AddWithValue("taskID", taskID);

            //open the connection, execute the query and close the connection
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            rowsAffected = oleDbCommand.ExecuteNonQuery();
            conn.Close();
            return rowsAffected > 0;
        }


        public int CountCompletedTasksInGoal(int goalID)
        {
            OleDbConnection conn = GetNewDBConnection();
            OleDbCommand oleDbCommand = new OleDbCommand("qCountCompletedTasksInGoal", conn);
            oleDbCommand.CommandType = CommandType.StoredProcedure;

            oleDbCommand.Parameters.AddWithValue("@goalID", goalID);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            int count = Convert.ToInt32(oleDbCommand.ExecuteScalar());
            conn.Close();

            return count;
        }

        public int CountTasksInGoal(int goalID)
        {
            OleDbConnection conn = GetNewDBConnection();
            OleDbCommand oleDbCommand = new OleDbCommand("qCountTasksInGoal", conn);
            oleDbCommand.CommandType = CommandType.StoredProcedure;

            oleDbCommand.Parameters.AddWithValue("@goalID", goalID);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            int count = Convert.ToInt32(oleDbCommand.ExecuteScalar());
            conn.Close();
            return count;
        }

        public int GetGoalIDOfTask(int taskID)
        {
            OleDbConnection conn = GetNewDBConnection();
            OleDbCommand oleDbCommand = new OleDbCommand("qGetGoalIDOfTask", conn);
            oleDbCommand.CommandType = CommandType.StoredProcedure;

            oleDbCommand.Parameters.AddWithValue("@taskID", taskID);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            object goalIDObject = oleDbCommand.ExecuteScalar();
            conn.Close();
            if (goalIDObject == null)
                return 0;
            else
               return Convert.ToInt32(goalIDObject);
            


           
        }
    }

  
}
