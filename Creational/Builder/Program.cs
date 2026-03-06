using Builder.StepwiseBuilder;
using Builder.FunctionalBuilder;
using Builder.FacetedBuilder;
using Builder.FluentBuilderInheritance;
using System.Text;


namespace Builder
{
    class Program
    {
        static void WithoutBuilder()
        {
            var hello = "hello";
            var sb = new StringBuilder();
            sb.Append("<p>");
            sb.Append(hello);
            sb.Append("</p>");
            Console.WriteLine(sb);

            var words = new[] { "hello", "world" };
            sb.Clear();
            sb.Append("<ul>");
            foreach (string word in words)
            {
                sb.AppendFormat("<li>{0}</li>", word);
            }
            sb.Append("</ul>");
            Console.WriteLine(sb);
        }

        static void WithBuilder()
        {
            var builder = new HtmlBuilder("ul");
            builder.AddChild("li", "hello");
            builder.AddChild("li", "world");
            Console.WriteLine(builder);

            // Fluent
            builder.Clear();
            builder.AddChild("li", "hello").AddChild("li", "world");
            Console.WriteLine(builder);
        }

        static void FluentBuilderWithInheritance()
        {
            FluentBuilderInheritance.Person person = FluentBuilderInheritance.Person.New.Called("dmitri").WorksAsA("quant").Build();
            Console.WriteLine(person);
        }

        static void StepwiseBuilder()
        {
            var car = CarBuilder.Create()  // ISpecifyCarType
                .OfType(CarType.Crossover) // ISpecifyWheelSize
                .WithWheels(18)            // IBuildCar
                .Build();

            Console.WriteLine(car);
        }

        static void FunctionalBuilder()
        {
            var person = new FunctionalBuilder.PersonBuilder()
                .Called("Sarah")
                .WorksAs("Developer")
                .Build();

            Console.WriteLine(person);
        }

        static void FacetedBuilder()
        {
            var builder = new FacetedBuilder.PersonBuilder();
            FacetedBuilder.Person person = builder
                .Works.At("Fabrikam")
                    .AsA("Engineer")
                    .Earning(123000)
                .Lives.At("123 London Road")
                    .In("London")
                    .withPostcode("SW12AC");

            Console.WriteLine(person);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Builder");
            Console.WriteLine("_______");
            Console.WriteLine("\nWithout Builder");
            WithoutBuilder();
            Console.WriteLine("\nWith Builder");
            WithBuilder();
            Console.WriteLine("\nFluent Builder with Inheritance");
            FluentBuilderWithInheritance();
            Console.WriteLine("\nStepwise Builder");
            StepwiseBuilder();
            Console.WriteLine("\nFunctional Builder");
            FunctionalBuilder();
            Console.WriteLine("\nFaceted Builder");
            FacetedBuilder();
        }
    }
}
