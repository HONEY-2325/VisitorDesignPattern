/******************************************************************************
 * Filename    = IComputerPart.cs
 *
 * Author      = Gagan Chandu Palla
 *
 * Product     = SoftwareDesignPatterns
 * 
 * Project     = VisitorPattern
 *
 * Description = Defines the interface for elements in the Visitor pattern.
 *               Provides the method `Accept` to accept a visitor.
 *****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
    // Element Interface
    public interface IComputerPart
    {
        void Accept(IComputerPartVisitor computerPartVisitor);
    }
}
