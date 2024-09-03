/******************************************************************************
 * Filename    = IComputerPartVisitor.cs
 *
 * Author      = Gagan Chandu Palla
 *
 * Product     = SoftwareDesignPatterns
 * 
 * Project     = VisitorPattern
 *
 * Description = Defines the visitor interface for the Visitor pattern.
 *               Includes methods to visit different types of computer parts.
 *****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
    // Visitor Interface
    public interface IComputerPartVisitor
    {
        void Visit(Mouse mouse);
        void Visit(Keyboard keyboard);
        void Visit(Monitor monitor);
    }
}
