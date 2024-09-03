/******************************************************************************
 * Filename    = NameVisitor.cs
 *
 * Author      = Gagan Chandu Palla
 *
 * Product     = SoftwareDesignPatterns
 * 
 * Project     = VisitorPattern
 *
 * Description = Concrete visitor that collects names of the computer parts.
 *               Implements methods to handle each type of computer part.
 *****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
    // Concrete Visitor to list down part names
    public class NameVisitor : IComputerPartVisitor
    {
        private readonly List<string> _names = new();

        public IEnumerable<string> Names => _names;

        public void Visit(Mouse mouse)
        {
            _names.Add("Mouse");
        }

        public void Visit(Keyboard keyboard)
        {
            _names.Add("Keyboard");
        }

        public void Visit(Monitor monitor)
        {
            _names.Add("Monitor");
        }
    }
}
