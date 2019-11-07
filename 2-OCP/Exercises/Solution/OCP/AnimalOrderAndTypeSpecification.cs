using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
    class AnimalOrderAndTypeSpecification : ISpecification<Animal>
    {
        AnimalClass _animalClass;
        AnimalOrder _animalOrder;
        public AnimalOrderAndTypeSpecification(AnimalClass animalClass, AnimalOrder animalOrder)
        {
            _animalClass = animalClass;
            _animalOrder = animalOrder;
        }

        public bool isSatisfied(Animal item) => item.Class == _animalClass && item.Order == _animalOrder;
    }
}
