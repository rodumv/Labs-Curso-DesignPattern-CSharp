using System;
using System.Collections.Generic;
using System.Text;

namespace ISPLibrary
{
    public class Car : IVehicle, IEngineVehicle
    {
        public int GetNumberOfWheel()
        {
            return 4;
        }

        public void Move()
        {
            Console.WriteLine("Moviendo");
        }

        public void startEngine()
        {
            Console.WriteLine("start");
        }

        public void stopEngine()
        {
            Console.WriteLine("stop");
        }
    }
}
