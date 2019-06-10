using System;
using System.Collections.Generic;
using System.Text;

namespace ISPLibrary
{
    class SimplePrinter : IScan, IPrint
    {
        public void Print(string content)
        {
            Console.WriteLine(content);
        }

        public void Scan(string content)
        {
            Console.WriteLine(content);
        }
    }
}
