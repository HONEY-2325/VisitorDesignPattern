/******************************************************************************
 * Filename    = PriceVisitor.cs
 *
 * Author      = Gagan Chandu Palla
 *
 * Product     = SoftwareDesignPatterns
 * 
 * Project     = VisitorPattern
 *
 * Description = Concrete visitor that calculates the total price of computer parts.
 *               Implements methods to handle each type of computer part.
 *****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
    public class PriceVisitor : IComputerPartVisitor
    {
        public double TotalPrice { get; private set; } = 0;

        public void Visit(Mouse mouse)
        {
            TotalPrice += 25; // Example price for Mouse
        }

        public void Visit(Keyboard keyboard)
        {
            TotalPrice += 50; // Example price for Keyboard
        }

        public void Visit(Monitor monitor)
        {
            TotalPrice += 100; // Example price for Monitor
        }
    }
}
