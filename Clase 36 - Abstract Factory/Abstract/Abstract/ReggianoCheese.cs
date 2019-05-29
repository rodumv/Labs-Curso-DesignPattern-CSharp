using System;
using static System.Console;
namespace Abstract
{
    internal class ReggianoCheese : ICheese
    {
        public ReggianoCheese()
        {
            Write("Agregando queso parmesano"  +Environment.NewLine);
        }
    }
}