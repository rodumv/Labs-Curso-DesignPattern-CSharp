using System;

namespace BuilderLibrary
{
    public class Sandwich
    {
        public string Bread { get; set; }
        public string Veggies { get; set; }
        public string Protein { get; set; }
        public string Condiments { get; set; }
        public string Cheese { get; set; }

        public Sandwich()
        {

        }

        public Sandwich(string bread, string veggies, string protein, string condiments, string cheese) : this()
        {
            Bread = bread;
            Veggies = veggies;
            Protein = protein;
            Condiments = condiments;
            Cheese = cheese;
        }
    }
}
