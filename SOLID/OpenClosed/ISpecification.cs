using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OpenClosed
{
    internal interface ISpecification<T>
    {
        public bool IsSatisfied(T t);
    }
}
