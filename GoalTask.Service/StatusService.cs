using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using GoalTask.Data.DataAccess;

namespace GoalTask.Service
{
   public class StatusService:IStatusService
    {
        public IStatusAccess StatusAccess { get; set; }
       

        public DataTable ViewStatus()
        {
            StatusAccess = new StatusAccess();
            return StatusAccess.ViewStatus();
        }

    }
}
