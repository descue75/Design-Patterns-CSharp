using SOLID.OpenClosed;
using SOLID.OpenClosed.Bad;
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

        static void OpenClosed()
        {
            var products = new Product[]
            {
                new Product("Apple", Color.Green, Size.Small),
                new Product("Tree", Color.Green, Size.Large),
                new Product("House", Color.Blue, Size.Large)
            };

            Console.WriteLine("All products:\n" + string.Join("\n", products));

            Console.WriteLine("\nFiltering the old way - all green items:");
            foreach( Product p in ProductFilter.FilterByColor(products, Color.Green))
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("\nFiltering the better way - all green items:");
            var betterFilter = new BetterProductFilter();
            foreach (Product p in betterFilter.Filter(products, new ColorSpecification(Color.Green)))
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("\nFiltering the better way - all large items:");
            foreach (Product p in betterFilter.Filter(products, new SizeSpecification(Size.Large)))
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("\nFiltering the better way - green and large items");
            var andSpecification = new AndSpecification<Product>(new ColorSpecification(Color.Green), new SizeSpecification(Size.Large));
            foreach (Product p in betterFilter.Filter(products, andSpecification))
            {
                Console.WriteLine(p); 
            }

            Console.WriteLine("\nFiltering the better way - green or large items");
            var orSpecification = new OrSpecification<Product>(new ColorSpecification(Color.Green), new SizeSpecification(Size.Large));
            foreach (Product p in betterFilter.Filter(products, orSpecification))
            {
                Console.WriteLine(p);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Single Responsibility Principle\n");
            SingleResponsibility();
            Console.WriteLine("\nOpen-Closed Principle\n");
            OpenClosed();
        }
    }
}
