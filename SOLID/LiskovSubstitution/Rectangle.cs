using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SOLID.LiskovSubstitution
{
    internal class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public int Area => Width * Height;

        public Rectangle()
        {
            
        }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
        }
    }
}
