using SOLID.SingleResponsibility;

namespace SOLID
{
    class Program
    {
        static void SingleResponsibility()
        {
            var j = new Journal();
            j.Test();
        }

        static void Main(string[] args)
        {
            SingleResponsibility();
        }
    }
}
