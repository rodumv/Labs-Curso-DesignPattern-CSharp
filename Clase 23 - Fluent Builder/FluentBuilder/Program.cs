using BuilderLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new SandwichBuilder()
                .WithMeat()
                .WithCheeseChedar()
                .WithMayoMustard();
        }
    }
}
