using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIPLibrary
{
    public class EmployeeManager : IEmployeeSearcheable
    {
        private readonly List<Employee> _employees = new List<Employee>();

        public void Save(Employee employee)
        {
            _employees.Add(employee);
        }

        public int GetEmployeesByGenderAndRole(Gender gender, Role role)
        {
           return  _employees.Where(o => o.Gender == gender && o.Role == role).ToList().Count();
        }
    }
}
