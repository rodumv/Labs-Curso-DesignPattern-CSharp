using BuilderLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var sandwich = new SandwichAssembly(new CheeseBurger());
            sandwich.Assemble();
            Console.WriteLine($"{sandwich.GetSandwich.Bread} {sandwich.GetSandwich.Cheese} {sandwich.GetSandwich.Protein} {sandwich.GetSandwich.Veggies} {sandwich.GetSandwich.Condiments}");
            Console.ReadLine();

        }
    }
}
