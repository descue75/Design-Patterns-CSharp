using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OpenClosed
{
    internal class SizeSpecification(Size filterSize) : ISpecification<Product>
    {
        public Size FilterSize { get; set; } = filterSize;
        
        public bool IsSatisfied(Product t)
        {
            return t.Size == FilterSize;
        }
    }
}
