using System;
using static System.Console;
namespace Abstract
{
    internal class MarinaraSauce : ISauce
    {
        public MarinaraSauce()
        {
            Write("Agregando salsa marinara" + Environment.NewLine);
        }
    }
}