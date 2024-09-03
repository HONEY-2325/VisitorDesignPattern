/******************************************************************************
 * Filename    = Program.cs
 *
 * Author      = Gagan Chandu Palla
 *
 * Product     = SoftwareDesignPatterns
 * 
 * Project     = VisitorPattern
 *
 * Description = Client code demonstrating the Visitor pattern with computer parts.
 *               Initializes a list of computer parts and applies PriceVisitor
 *               and NameVisitor to calculate total price and collect part names.
 *****************************************************************************/

using VisitorDesignPattern;
using Monitor = VisitorDesignPattern.Monitor;

namespace VisitorDesignPatternApp
{
    // Client Code
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            var computerParts = new List<IComputerPart>
            {
                new Mouse(),
                new Keyboard(),
                new Monitor()
            };

            var priceVisitor = new PriceVisitor();
            var nameVisitor = new NameVisitor();

            foreach (IComputerPart part in computerParts)
            {
                part.Accept(priceVisitor);
                part.Accept(nameVisitor);
            }

            Console.WriteLine($"Total Price: {priceVisitor.TotalPrice}");
            Console.WriteLine($"Part Names: {string.Join(", ", nameVisitor.Names)}");

            Console.ReadKey();
        }
    }
}
