/******************************************************************************
 * Filename    = Monitor.cs
 *
 * Author      = Gagan Chandu Palla
 *
 * Product     = SoftwareDesignPatterns
 * 
 * Project     = VisitorPattern
 *
 * Description = Concrete implementation of a computer part (Monitor).
 *               Implements the `Accept` method to accept a visitor.
 *****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
    // Concrete Element
    public class Monitor : IComputerPart
    {
        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.Visit(this);
        }
    }
}
