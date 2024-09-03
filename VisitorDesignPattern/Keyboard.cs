/******************************************************************************
 * Filename    = Keyboard.cs
 *
 * Author      = Gagan Chandu Palla
 *
 * Product     = SoftwareDesignPatterns
 * 
 * Project     = VisitorPattern
 *
 * Description = Concrete implementation of a computer part (Keyboard).
 *               Implements the `Accept` method to accept a visitor.
 *****************************************************************************/

namespace VisitorDesignPattern
{
    // Concrete Element
    public class Keyboard : IComputerPart
    {
        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.Visit(this);
        }
    }
}
