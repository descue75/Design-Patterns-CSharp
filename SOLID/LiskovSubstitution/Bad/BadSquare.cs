using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.LiskovSubstitution.Bad
{
    internal class BadSquare : Rectangle
    {
        public new int Width
        {
            set => base.Width = base.Height = value;
        }

        public new int Height
        {
            set => base.Height = base.Width = value;
        }
    }
}
