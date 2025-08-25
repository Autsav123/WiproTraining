//Importing Nunit Framework and our application
using NUnit.Framework;
using Demo_MathLibrary_Testing_Using__Nunit; //Added this as Reference
namespace MathLibrary.Tests
{
    public class calculatorTest
        
    {
        private Calculator calculator;
        [SetUp] //Attributes
        public void Setup()
        {
            calculator= new Calculator();  //allocting memory using 'new'
        }

        [Test]
        public void Add_shouldReturnCorrectSum()
        {
            //Assert.Pass(); passing the flow of execution
            int result = calculator.Add(2, 3);
            Assert.That(result,Is.EqualTo(5));
        }

        public void Subtract_shouldReturnCorrectDifference()
        {
            int result = calculator.Subs(5, 3);
            Assert.That(result, Is.EqualTo(2 ));
            Assert.AreEqual(2, result);
           // Assert.Pass();
        }
    }
}