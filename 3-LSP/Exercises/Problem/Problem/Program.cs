using LSPLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.noise = "AWW";
            animal.MakeNoise();
            animal.Fly();
            Console.ReadLine();

        }
    }
}
