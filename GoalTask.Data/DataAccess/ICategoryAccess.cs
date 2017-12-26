using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace GoalTask.Data.DataAccess
{
   public  interface ICategoryAccess
    {
        DataTable ViewCategory();

    }
}
