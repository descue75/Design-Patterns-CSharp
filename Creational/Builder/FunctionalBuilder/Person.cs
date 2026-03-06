using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.FunctionalBuilder
{
    internal class Person
    {
        public string ?Name, Position;

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
        }
    }
}
