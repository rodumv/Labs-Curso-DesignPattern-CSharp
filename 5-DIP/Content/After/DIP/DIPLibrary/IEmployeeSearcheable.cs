using System;
using System.Collections.Generic;
using System.Text;

namespace DIPLibrary
{
    public interface IEmployeeSearcheable
    {
        int GetEmployeesByGenderAndRole(Gender gender, Role role);
    }
}
