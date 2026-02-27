using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OpenClosed
{
    internal class BetterProductFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            return items.Where(spec.IsSatisfied);
        }
    }
}
