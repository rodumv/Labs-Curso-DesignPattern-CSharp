using System;
using System.Collections.Generic;
using System.Text;

namespace ISPLibrary
{
    public interface IPrinterTask
    {
        void Scan(string content);
        void Print(string content);
        void Fax(string content);
    }
}
