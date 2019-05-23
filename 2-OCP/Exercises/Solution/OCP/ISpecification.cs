using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
    public interface ISpecification<T>
    {
        bool isSatisfied(T item);
    }
}
