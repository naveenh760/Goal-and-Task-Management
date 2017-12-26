using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.OleDb;


namespace GoalTask.Data.DataAccess
{
    
    /// <summary>
    /// ConnectionAccess abstract class
    /// </summary>
    public abstract class ConnectionAccess
    {
        protected string ConnectionString
        {
            get
            {
                 return ConfigurationManager.ConnectionStrings["GoalTaskDBConnection"].ToString();
              
            }

        }

        protected OleDbConnection GetNewDBConnection()
        {
               
                OleDbConnection conn = new OleDbConnection(this.ConnectionString);
                return conn;
            
        }
    }
}
