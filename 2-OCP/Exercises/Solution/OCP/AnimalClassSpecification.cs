using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
    public class AnimalClassSpecification : ISpecification<Animal>
    {
        private readonly AnimalClass _class;

        public AnimalClassSpecification(AnimalClass animalClass)
        {
            _class = animalClass;
        }

        public bool isSatisfied(Animal item) => item.Class == _class;
    }
}
