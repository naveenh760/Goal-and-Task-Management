using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace GoalTask.Data.DataAccess
{
    
    using GoalTask.Data.DataModel;
    /// <summary>
    /// Interface IGoalAccess
    /// </summary>
    public interface IGoalAccess
    {
        bool AddGoal(GoalModel goal);
        DataTable ViewGoalName();
        DataTable ViewAllGoals();
        DataTable FilterGoals(object categoryID,object goalStatusID,object startDate,object endDate);

        bool UpdateGoal(GoalModel goal);
        DataRow ViewGoalById(int id);
        bool DeleteGoal(int id);

        bool CloseGoal(DateTime closingDate, int goalID);

    }
}
