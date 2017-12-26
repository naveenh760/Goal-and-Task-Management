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
   public class GoalService:IGoalService
    {

        public IGoalAccess GoalAccess { get; set; }
        public GoalService()
        {
            this.GoalAccess = new GoalAccess();
        }

        public bool AddGoal(GoalModel goal)
        {
            return GoalAccess.AddGoal(goal);
        }

        public DataTable ViewGoalName()
        {
            return GoalAccess.ViewGoalName();
            
        }

        public DataTable ViewAllGoals()
        {
            return GoalAccess.ViewAllGoals();
        }

        public DataTable FilterGoals(int categoryID, int goalStatusID, DateTime? startDate, DateTime? endDate)
        {
            object categoryIDN, goalStatusIDN,startDateN,endDateN;
            if (categoryID == -1)
            {
                categoryIDN = DBNull.Value;
            }
            else
            {
                categoryIDN = categoryID;
            }


            if (goalStatusID == -1)
            {
                goalStatusIDN = DBNull.Value;
            }
            else
            {
                goalStatusIDN = goalStatusID;
            }


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
            
              
  
            return GoalAccess.FilterGoals(categoryIDN,goalStatusIDN,startDateN,endDateN);
        }

        public bool UpdateGoal(GoalModel goal)
        {
            return GoalAccess.UpdateGoal(goal);
        }

        public DataRow ViewGoalById(int id)
        {
            return GoalAccess.ViewGoalById(id);
        }

        public bool DeleteGoal(int id)
        {
            return GoalAccess.DeleteGoal(id);
        }
        
        public bool CloseGoal(DateTime closingDate,int goalID)
        {
            return GoalAccess.CloseGoal(closingDate, goalID);
        }


       
    }
}
