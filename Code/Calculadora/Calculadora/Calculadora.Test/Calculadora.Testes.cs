using System;
using NUnit.Framework;

namespace Calculadora.Tests
{
    [TestFixture]
    public class CalculadaTests
    {//update-package NUnit -version 2.6.4
        [Test]
        public void ShouldAddTwoNumbers()
        {
            ICalculator sut = new Calculator();
            int expectedResult = sut.Add(7, 8);
            Assert.That(expectedResult, Is.EqualTo(15));
        }

        [Test]
        public void ShouldMulTwoNumbers()
        {
            ICalculator sut = new Calculator();
            int expectedResult = sut.Mul(7, 8);
            Assert.That(expectedResult, Is.EqualTo(56));
        }

    }
}
