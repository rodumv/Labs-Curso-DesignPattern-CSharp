using System;
using static System.Console;
namespace Abstract
{
    internal class IThinCrustDough : IDough
    {
        public IThinCrustDough()
        {
            Write("Agregando masa delgada" + Environment.NewLine);
        }
    }
}