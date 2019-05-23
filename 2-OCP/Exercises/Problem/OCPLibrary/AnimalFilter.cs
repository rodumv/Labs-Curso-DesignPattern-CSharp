using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCPLibrary
{
    public class AnimalFilter
    { 
        public List<Animal> FilterByClass(IEnumerable<Animal> animals, AnimalClass animalClass) =>
            animals.Where(o => o.Class == animalClass).ToList();
    }
}
