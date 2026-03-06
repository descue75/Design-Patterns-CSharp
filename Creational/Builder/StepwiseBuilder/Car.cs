using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.StepwiseBuilder
{
    internal class Car
    {
        public CarType Type;
        public int WheelSize;

        public override string ToString()
        {
            return $"{nameof(Type)}: {Type}, {nameof(WheelSize)}: {WheelSize}";
        }
    }
}
