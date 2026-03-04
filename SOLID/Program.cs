using SOLID.DependencyInversion;
using SOLID.LiskovSubstitution;
using SOLID.LiskovSubstitution.Bad;
using SOLID.OpenClosed;
using SOLID.OpenClosed.Bad;
using SOLID.SingleResponsibility;

namespace SOLID
{
    class Program
    {
        private static void SingleResponsibility()
        {
            var j = new Journal();
            j.AddEntry("I criend today.");
            j.AddEntry("I ate a bug.");
            Console.WriteLine(j);

            var p = new Persistence();
            var filename = "journal.txt";
            p.SaveToFile(j, filename);
        }

        private static void OpenClosed()
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

        private static void LiskovSubstitution()
        {
            var rectangle = new Rectangle(2, 4);
            Console.WriteLine($"{rectangle} has area {rectangle.Area}");

            // Will not set width properly, as it is using the Rectangle Width setter
            Rectangle badSquare = new BadSquare();
            badSquare.Height = 4;
            Console.WriteLine("Bad Square");
            Console.WriteLine($"{badSquare} has area {badSquare.Area}");

            // Functionality of Square should be preserved even if it is instantiated as a rectangle
            Rectangle goodSquare = new Square();
            goodSquare.Height = 4;
            Console.WriteLine("Good Square");
            Console.WriteLine($"{goodSquare} has area {goodSquare.Area}");
        }

        private static void DependencyInversion()
        {
            var parent = new Person { Name = "John" };
            var child1 = new Person { Name = "Chris" };
            var child2 = new Person { Name = "Mary" };

            var relationships = new Relationships();
            relationships.AddParentAndChild(parent, child1);
            relationships.AddParentAndChild(parent, child2);

            new Research(relationships);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Single Responsibility Principle\n");
            SingleResponsibility();
            Console.WriteLine("\nOpen-Closed Principle\n");
            OpenClosed();
            Console.WriteLine("\nLiskov Substitution Principle\n");
            LiskovSubstitution();
            Console.WriteLine("\nDependency Inversion Principle\n");
            DependencyInversion();
        }
    }
}
