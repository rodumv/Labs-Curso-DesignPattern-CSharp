using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
    public interface IFilter<T>
    {
        List<T> Filter(IEnumerable<T> animals, ISpecification<T> specification);
    }
}
