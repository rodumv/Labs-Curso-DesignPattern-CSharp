using LSPLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            ICanFly animal = new  Bird();
            animal.Noise = "AWW";
            animal.MakeNoise();
            animal.Fly();
            Console.ReadLine();

        }
    }
}
