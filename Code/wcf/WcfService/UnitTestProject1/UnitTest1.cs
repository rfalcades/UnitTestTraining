using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfService;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetData()
        {
            String Atual = "3";
            String Esperado = "Empresa Programador Feliz:8793";
            Service1 objServico = new Service1();
            Atual = objServico.GetData(3);
            Assert.AreEqual(Atual, Esperado);

        }
    }
}
