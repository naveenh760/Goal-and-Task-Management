using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoalTask.Data.DataModel;
using System.Data;

/// <summary>
/// Interface IGoalService
/// </summary>
namespace GoalTask.Service
{
    public interface IGoalService
    {
        bool AddGoal(GoalModel goal);
        DataTable ViewGoalName();
        DataTable ViewAllGoals();
        DataTable FilterGoals(int categoryID, int GoalStatusID, DateTime? startDate, DateTime? endDate);

        bool UpdateGoal(GoalModel goal);
        DataRow ViewGoalById(int id);
        bool DeleteGoal(int id);
        bool CloseGoal(DateTime closingDate, int goalID);

    }
}
