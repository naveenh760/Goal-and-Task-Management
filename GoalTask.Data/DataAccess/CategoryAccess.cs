using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace GoalTask.Data.DataAccess
{
   public class CategoryAccess:ConnectionAccess,ICategoryAccess
    {
       public  DataTable ViewCategory()
        {
            DataTable dataTable = new DataTable();
            using(OleDbDataAdapter oleDbDataAdapter= new OleDbDataAdapter())
            {
                oleDbDataAdapter.SelectCommand = new OleDbCommand("qViewCategory");
                oleDbDataAdapter.SelectCommand.Connection = GetNewDBConnection();
                oleDbDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                oleDbDataAdapter.Fill(dataTable);
            }
            return dataTable;
        }
    }
}
