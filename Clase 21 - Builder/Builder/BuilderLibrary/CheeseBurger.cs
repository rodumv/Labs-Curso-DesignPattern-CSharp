using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderLibrary
{
    public class CheeseBurger : SandwichBuilder
    {
        public CheeseBurger()
        {
            _sandwich = new Sandwich();
        }
        public override void AddBread()
        {
            _sandwich.Bread = "Pan frica";
        }

        public override void AddCheese()
        {
            _sandwich.Cheese = "Queso cheedar";
        }

        public override void AddCondiments()
        {
            _sandwich.Condiments = "Mayonesa";
        }

        public override void AddProtein()
        {
            _sandwich.Protein = "Vacuno";
        }

        public override void AddVeggies()
        {
            _sandwich.Veggies = "";
        }
    }
}
