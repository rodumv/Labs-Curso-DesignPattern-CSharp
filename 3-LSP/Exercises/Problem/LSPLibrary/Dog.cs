using System;
using System.Collections.Generic;
using System.Text;

namespace LSPLibrary
{
    class Dog : Animal
    {
        public override void Fly()
        {
            throw new NotImplementedException("No puedo volar");
        }
    }
}
