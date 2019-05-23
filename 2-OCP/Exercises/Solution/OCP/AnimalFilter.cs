using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCP
{
    public class AnimalFilter : IFilter<Animal>
    {
        public List<Animal> Filter(IEnumerable<Animal> animals, ISpecification<Animal> specification) => animals.Where(o => specification.isSatisfied(o)).ToList();
    }
}
