using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSampleCode.UnitTests
{
    [TestClass]
    public class MathOperationsTests
    {
        private MathOperations _mathOperations;

        [TestInitialize]
        public void Init()
        {
            _mathOperations = new MathOperations();
        }

        [TestMethod]
        [DataRow(10, 5, 5)]
        [DataRow(999, 1, 998)]
        [DataRow(650, 500, 150)]
        public void Subtract_ValidInput_ReturnsCorrectResult(int numberOne, int numberTwo, int expectedResult)
        {
            var result = _mathOperations.Subtract(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(1200, 10)] //= 1200
        [DataRow(1300, 10)] // sup à 1200
        public void Subtract_InvalidFirstParameter_ThrowsArgumentException(int numberOne, int numberTwo)
        {
        
            Assert.ThrowsException<ArgumentException>(() => _mathOperations.Subtract(numberOne, numberTwo));
        }

        [TestMethod]
        [DataRow(5, 64)] //number 2 sup à number 1
        [DataRow(3, 30)]
        public void Subtract_InvalidSecondParameter_ThrowsArgumentException(int numberOne, int numberTwo)
        {
            
            Assert.ThrowsException<ArgumentException>(() => _mathOperations.Subtract(numberOne, numberTwo));
        }

        [TestMethod]
        [DataRow(-1)]//nombre négatif
        [DataRow(-10)]
        public void GetColorFromOddsNumber_NegativeInput_ThrowsArgumentException(int number)
        {
         
            Assert.ThrowsException<ArgumentException>(() => _mathOperations.GetColorFromOddsNumber(number));
        }

        [TestMethod]
        [DataRow(10, "Red")]
        [DataRow(11, "Blue")]
        [DataRow(12, "Red")]
        public void GetColorFromOddsNumber_ValidInput_ReturnsCorrectColor(int number, string expectedColor)
        {
           
            var result = _mathOperations.GetColorFromOddsNumber(number);

            
            Assert.AreEqual(expectedColor, result);
        }


    }
}