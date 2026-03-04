using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace SOLID.InterfaceSegregation.Bad
{
    internal interface IMachine
    {
        void Print(Document d);
        void Scan(Document d);
        void Fax(Document d);
    }
}
