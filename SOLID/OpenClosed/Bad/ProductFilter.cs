using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OpenClosed.Bad
{
    internal class ProductFilter
    {
        public static IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            return products.Where(x => x.Size == size);
        }

        public static IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            return products.Where(x => x.Color == color);
        }

        #region Violates Open-Closed Principle Every Time a New Filter Is Needed
        public static IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products, Size size, Color color)
        {
            return products.Where(x => x.Size == size && x.Color == color);
        }
        #endregion 
    }
}
