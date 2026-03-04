using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.InterfaceSegregation
{
    internal class PhotoCopier : IPrinter, IScanner
    {
        public void Print(Document d)
        {
            Console.WriteLine($"{nameof(Print)}");
        }

        public void Scan(Document d)
        {
            Console.WriteLine($"{nameof(Scan)}");
        }
    }
}
