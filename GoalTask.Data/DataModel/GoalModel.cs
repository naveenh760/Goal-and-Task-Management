using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalTask.Data.DataModel
{
  

    /// <summary>
    /// GoalModel class
    /// </summary>
   public class GoalModel
    {
        public int GoalId { get; set; }
        public String GoalName { get; set; }
        public String GoalDesription { get; set; }
        public DateTime GoalDeadline { get; set; }
        public DateTime ClosingDate { get; set; }
        public int GoalStatus { get; set; }
        public int Category { get; set; }



    }
}
