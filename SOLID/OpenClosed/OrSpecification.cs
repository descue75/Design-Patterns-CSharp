using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OpenClosed
{
    internal class OrSpecification<T>(params ISpecification<T>[] specifications) : ISpecification<T>
    {
        public bool IsSatisfied(T t) => specifications.Any(spec => spec.IsSatisfied(t));

    }
}
