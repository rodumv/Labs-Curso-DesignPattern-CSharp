using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIPLibrary
{
    public class EmployeeSearch
    {
        private readonly IEmployeeSearcheable employeeSearch;

        public EmployeeSearch(IEmployeeSearcheable employeeManager)
        {
            this.employeeSearch = employeeManager;
        }

        public int GetEmployeesByGenderAndRole(Gender gender, Role role)
        {
           return employeeSearch.GetEmployeesByGenderAndRole(gender, role);
        }

    }
}
