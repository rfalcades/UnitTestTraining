using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculadora.Tests
{
    public class Calculadora
    {
        [TestFixture]
        public class CalculatorTest
        {
            ICalculator sut;
            [TestFixtureSetUp]
            public void TestSetup1()
            {
                sut = new Calculator();
            }
            [Test]
            public void ShouldAddTwoNumbers1()
            {

                int expectedResult = sut.Add(7, 8);
                Assert.That(expectedResult, Is.EqualTo(15));
            }
            [Test]
            public void ShouldMulTwoNumbers1()
            {

                int expectedResult = sut.Mul(7, 8);
                Assert.That(expectedResult, Is.EqualTo(56));
            }

            [Test]
            [Ignore]
            public void ShouldNotMulTwoNumbers()
            {
                int expectedResult = sut.Mul(7, 8);
                Assert.That(expectedResult, Is.EqualTo(15));
            }


            [TestFixtureTearDown]
            public void TestTearDown1()
            {
                sut = null;
            }

        }

    }
}
