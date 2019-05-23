using System;
using System.Collections.Generic;
using System.Text;

namespace LSPLibrary
{
    public class Bird : Animal, ICanFly
    {
        public void Fly()
        {
            Console.WriteLine("Puedo volar");
        }
    }
}
