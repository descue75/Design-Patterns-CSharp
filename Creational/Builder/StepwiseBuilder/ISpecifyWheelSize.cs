using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.StepwiseBuilder
{
    internal interface ISpecifyWheelSize
    {
        IBuildCar WithWheels(int size);
    }
}
