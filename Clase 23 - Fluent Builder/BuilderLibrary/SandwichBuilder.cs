using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderLibrary
{
    public class SandwichBuilder
    {
        protected Sandwich _sandwich;

        public Sandwich Sandwich
        {
            get { return _sandwich; }
        }

        public SandwichBuilder WithMeat()
        {
            _sandwich.Protein = "Carne";
            return this;
        }
        public SandwichBuilder WithCheeseChedar()
        {
            _sandwich.Cheese = "Queso chedar";
            return this;
        }

        public SandwichBuilder WithMayoMustard()
        {
            _sandwich.Cheese = "Mayonesa, Mostaza";
            return this;
        }
        
    }
}
