using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using GoalTask.Data.DataAccess;

namespace GoalTask.Service
{
   public class CategoryService:ICategoryService
    {
        public ICategoryAccess CategoryAccess { get; set; }
    
        public DataTable ViewCategory()
        {
            CategoryAccess = new CategoryAccess();
            return CategoryAccess.ViewCategory();
        }

    }
}
