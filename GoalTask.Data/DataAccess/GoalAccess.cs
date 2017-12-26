using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using GoalTask.Data.DataModel;
/// <summary>
/// Data access class for Goal table
/// </summary>
namespace GoalTask.Data.DataAccess
{
    public class GoalAccess : ConnectionAccess, IGoalAccess
    {
        public virtual bool AddGoal(GoalModel goal)
        {
                var rowsAffected=0;
                OleDbConnection conn = GetNewDBConnection();
                OleDbCommand oleDbCommand = new OleDbCommand("qInsertGoal", conn);
                oleDbCommand.CommandType = CommandType.StoredProcedure;
            
                

                //Add the input parameters to the parameter collection
                oleDbCommand.Parameters.AddWithValue("@GoalName", goal.GoalName);
                oleDbCommand.Parameters.AddWithValue("@GoalDescription", goal.GoalDesription);
                oleDbCommand.Parameters.AddWithValue("@GoalDeadline", goal.GoalDeadline.ToShortDateString());
                oleDbCommand.Parameters.AddWithValue("@GoalStatus", goal.GoalStatus);
                oleDbCommand.Parameters.AddWithValue("@CategoryID", goal.Category);

            //open the connection, execute the query and close the connection
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            
                rowsAffected = oleDbCommand.ExecuteNonQuery();
                conn.Close();
                

            

            return rowsAffected > 0;
        }

        public virtual DataTable ViewGoalName()
        {
            DataTable dataTable = new DataTable();
            using (OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter())
            {
                oleDbDataAdapter.SelectCommand = new OleDbCommand("qViewGoalName");
                oleDbDataAdapter.SelectCommand.Connection = GetNewDBConnection();
                oleDbDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                oleDbDataAdapter.Fill(dataTable);
            }
            return dataTable;
        }

        public virtual DataTable ViewAllGoals()
        {
            DataTable dataTable = new DataTable();
            using (OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter())
            {
                oleDbDataAdapter.SelectCommand = new OleDbCommand("qViewAllGoals");
                oleDbDataAdapter.SelectCommand.Connection = GetNewDBConnection();
                oleDbDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                oleDbDataAdapter.Fill(dataTable);
            }
            return dataTable;
        }

        public virtual DataTable FilterGoals(object categoryID,object goalStatusID,object startDate,object endDate)
        {
            
            DataTable data = new DataTable();
            using (OleDbDataAdapter oleDbDataAdpater=new OleDbDataAdapter())
            {                  
                oleDbDataAdpater.SelectCommand = new OleDbCommand("qFilterGoals");
                oleDbDataAdpater.SelectCommand.Connection = GetNewDBConnection();
                oleDbDataAdpater.SelectCommand.CommandType = CommandType.StoredProcedure;
                oleDbDataAdpater.SelectCommand.Parameters.AddWithValue("@startDate", startDate);
                oleDbDataAdpater.SelectCommand.Parameters.AddWithValue("@endDate", endDate);
                oleDbDataAdpater.SelectCommand.Parameters.AddWithValue("@category", categoryID);
                oleDbDataAdpater.SelectCommand.Parameters.AddWithValue("@status", goalStatusID);
                oleDbDataAdpater.Fill(data);
            }
            return data;
        }

        public virtual bool UpdateGoal(GoalModel goal)
        {
            var rowsAffected = 0;
            OleDbConnection conn = GetNewDBConnection();
            OleDbCommand oleDbCommand = new OleDbCommand("qUpdateGoal", conn);
            oleDbCommand.CommandType = CommandType.StoredProcedure;

            //Add the input parameters to the parameter collection
            oleDbCommand.Parameters.AddWithValue("@GoalName", goal.GoalName);
            oleDbCommand.Parameters.AddWithValue("@GoalDescription", goal.GoalDesription);
            oleDbCommand.Parameters.AddWithValue("@GoalStatus", goal.GoalStatus);
            oleDbCommand.Parameters.AddWithValue("@CategoryID", goal.Category);
            oleDbCommand.Parameters.AddWithValue("@GoalID", goal.GoalId);

            //open the connection, execute the query and close the connection
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            rowsAffected = oleDbCommand.ExecuteNonQuery();
            conn.Close();
            return rowsAffected > 0;
        }

        public virtual DataRow ViewGoalById(int id)
        {
            DataTable dataTable = new DataTable();
            DataRow dataRow;
            using (OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter())
            {
                oleDbDataAdapter.SelectCommand = new OleDbCommand("qViewGoalById");
                oleDbDataAdapter.SelectCommand.Connection = GetNewDBConnection();
                oleDbDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                oleDbDataAdapter.SelectCommand.Parameters.AddWithValue("@GoalID", id);
                oleDbDataAdapter.Fill(dataTable);
            }

            dataRow = dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;
            return dataRow;
           
        }

        public virtual bool DeleteGoal(int id)
        {
            var rowsAffected = 0;
            OleDbConnection conn = GetNewDBConnection();
            OleDbCommand oleDbCommand = new OleDbCommand("qDeleteGoal", conn);
            oleDbCommand.CommandType = CommandType.StoredProcedure;

            oleDbCommand.Parameters.AddWithValue("@GoalID", id);

            //open the connection, execute the query and close the connection
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            rowsAffected = oleDbCommand.ExecuteNonQuery();
            conn.Close();
            return rowsAffected > 0;
        }

        public virtual bool CloseGoal(DateTime closingDate, int goalID)
        {
            var rowsAffected = 0;
            OleDbConnection conn = GetNewDBConnection();
            OleDbCommand oleDbCommand = new OleDbCommand("qCloseGoal", conn);
            oleDbCommand.CommandType = CommandType.StoredProcedure;

            oleDbCommand.Parameters.AddWithValue("@closingDate", closingDate.ToShortDateString());
            oleDbCommand.Parameters.AddWithValue("@goalID", goalID);


            //open the connection, execute the query and close the connection
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            rowsAffected = oleDbCommand.ExecuteNonQuery();
            conn.Close();
            return rowsAffected > 0;
        }
    }
}
