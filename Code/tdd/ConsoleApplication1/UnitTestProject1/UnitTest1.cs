using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Int32 esperado = 6;
            objeto obj = new objeto(10);
            Int32 obtido = obj.estoque(2);
            objeto obj1 = new objeto(10);
            obtido = obj1.estoque(2);
            Assert.AreEqual(esperado, obtido);
        }
    }
}
