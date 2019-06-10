using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIPLibrary
{
    public class EmployeeManager 
    {
        private readonly List<Employee> _employees = new List<Employee>();

        public void Save(Employee employee)
        {
            _employees.Add(employee);
        }

    }
}
