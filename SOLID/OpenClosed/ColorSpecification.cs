using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OpenClosed
{
    internal class ColorSpecification(Color filterColor) : ISpecification<Product>
    {
        public Color FilterColor { get; set; } = filterColor;

        public bool IsSatisfied(Product t)
        {
            return t.Color == FilterColor;
        }
    }
}
