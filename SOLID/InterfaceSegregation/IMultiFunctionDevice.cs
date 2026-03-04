using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.InterfaceSegregation
{
    internal interface IMultiFunctionDevice : IPrinter, IScanner, IFaxer
    {
    }
}
