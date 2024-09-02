using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VisitorDesignPattern;
using Monitor = VisitorDesignPattern.Monitor;

namespace VisitorDesignPatternTests
{
    [TestClass]
    public class VisitorDesignPatternTests
    {
        [TestMethod]
        public void PriceVisitor_ShouldCalculateCorrectTotalPrice()
        {
            // Arrange
            var computerParts = new List<IComputerPart>
            {
                new Mouse(),
                new Keyboard(),
                new Monitor()
            };

            var priceVisitor = new PriceVisitor();

            // Act
            foreach (IComputerPart part in computerParts)
            {
                part.Accept(priceVisitor);
            }

            // Assert
            Assert.AreEqual(175, priceVisitor.TotalPrice, "The total price calculation is incorrect.");
        }

        [TestMethod]
        public void NameVisitorShouldCollectCorrectPartNames()
        {
            // Arrange
            var computerParts = new List<IComputerPart>
            {
                new Mouse(),
                new Keyboard(),
                new Monitor()
            };

            var nameVisitor = new NameVisitor();

            // Act
            foreach (IComputerPart part in computerParts)
            {
                part.Accept(nameVisitor);
            }

            // Assert
            var expectedNames = new List<string> { "Mouse", "Keyboard", "Monitor" };

            // Convert nameVisitor.Names to List or ICollection
            CollectionAssert.AreEquivalent(expectedNames, nameVisitor.Names.ToList(), "The part names collection is incorrect.");
        }


        [TestMethod]
        public void PriceVisitor_ShouldHandleEmptyPartsList()
        {
            // Arrange
            var computerParts = new List<IComputerPart>();
            var priceVisitor = new PriceVisitor();

            // Act
            foreach (IComputerPart part in computerParts)
            {
                part.Accept(priceVisitor);
            }

            // Assert
            Assert.AreEqual(0, priceVisitor.TotalPrice, "The total price should be 0 for an empty parts list.");
        }



    }
}
