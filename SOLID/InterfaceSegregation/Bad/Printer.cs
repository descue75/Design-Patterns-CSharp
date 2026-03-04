using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace SOLID.InterfaceSegregation.Bad
{
    internal class Printer : IMachine
    {
        public void Print(Document d)
        {
            Console.WriteLine($"{nameof(Print)}");
        }

        #region Violates Interface Segregation, we don't want implementations that aren't fully implemented 
        public void Scan(Document d)
        {
            throw new NotImplementedException();
        }

        public void Fax(Document d)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
