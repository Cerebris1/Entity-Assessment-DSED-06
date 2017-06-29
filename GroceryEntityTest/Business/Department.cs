using GroceryEntityTest.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GroceryEntityTest
{
    public class ChooseDepartmentClass
    {
        public IEnumerable GetDepartment()
        {
            // Allows the user to choose a department from the DB which will then populate into the cbxdepartment to be selected from there
            using (var context = new GroceryTestDBEntities())
            {
                var Department = context.AllDeptsAllProductsAllDatas.Select(a => a.Department).Distinct().ToList();
                return Department;
            }
        }
    }
}
