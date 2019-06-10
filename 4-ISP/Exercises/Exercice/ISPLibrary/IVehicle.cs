using System;

namespace ISPLibrary
{
    public interface IVehicle
    {
        void Move();
        int GetNumberOfWheel();
        int startEngine();
        int stopEngine();
       
    }
}

