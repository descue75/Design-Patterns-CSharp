using SOLID.SingleResponsibility;

namespace SOLID
{
    class Program
    {
        static void SingleResponsibility()
        {
            var j = new Journal();
            j.AddEntry("I criend today.");
            j.AddEntry("I ate a bug.");
            Console.WriteLine(j);

            var p = new Persistence();
            var filename = "journal.txt";
            p.SaveToFile(j, filename);
        }

        static void Main(string[] args)
        {
            SingleResponsibility();
        }
    }
}
