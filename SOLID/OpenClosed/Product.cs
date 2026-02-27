using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SOLID.OpenClosed
{
    internal class Product(string name, Color color, Size size)
    {
        public string Name { get; set; } = name ?? throw new ArgumentNullException(paramName: nameof(name));
        public Color Color { get; set; } = color;
        public Size Size { get; set; } = size;

        public override string ToString()
        {
            return $"Name: {Name}, Color: {Color}, Size: {Size}";
        }
    }
}
