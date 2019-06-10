using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIPLibrary
{
    public class EmployeeSearch
    {
        private readonly EmployeeManager employeeSearch;

        public EmployeeSearch(EmployeeManager employeeManager)
        {
            this.employeeSearch = employeeManager;
        }

        public int GetMaleExecutives()
        {
            throw new NotImplementedException();
        }

    }
}
