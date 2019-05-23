using System;
using System.Collections.Generic;
using System.Text;

namespace ISPLibrary
{
    public class Bicycle : IVehicle
    {
        public int GetNumberOfWheel()
        {
            return 2;
        }

        public void Move()
        {
            Console.WriteLine("Moviendo");
        }

    }
}
