using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID.OpenClosed
{
    internal class AndSpecification<T>(params ISpecification<T>[] specifications)
        : ISpecification<T>
    {
        public bool IsSatisfied(T t) =>
            specifications.All(s => s.IsSatisfied(t));
    }
}
