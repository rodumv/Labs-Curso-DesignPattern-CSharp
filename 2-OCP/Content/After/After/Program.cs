using OCPLibrary;
using System.Collections.Generic;
using static System.Console;
namespace Before
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IApplicant> persons = new List<IApplicant>()
            {
                new Person{ FirstName = "Rodrigo", LastName="Morales"},
                new Doctor{ FirstName = "Miguel", LastName="Sandoval"},
                new Nurse{ FirstName = "Robert", LastName="Martin"}
            };

            List<Staff> staffs = new List<Staff>();
            foreach(var staff in persons)
            {
                staffs.Add(staff.Processor.Create(staff));
            }

            foreach (var staff in staffs)
            {
                WriteLine($"Bienvenido {staff.FirstName}, {staff.LastName} , {staff.Email}");
            }
            ReadLine();
        }
        


    }
}
