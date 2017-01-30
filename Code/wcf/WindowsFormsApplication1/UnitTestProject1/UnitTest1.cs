using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WindowsFormsApplication1.ServiceReference1;
using WindowsFormsApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetNomeFinal()
        {
            string atual = "Empresa Programador Feliz:8793";
            string esperado = "Empresa Programador Feliz:8793/0001"; 
            Mock<IService1> wcfMock = new Mock<IService1>();
              wcfMock.Setup<string>(s => s.GetData(It.IsAny<int>())).Returns(atual);
              WindowsFormsApplication1.ServiceReference1.IService1 wcfMockObject = wcfMock.Object;
              WindowsFormsApplication1.classeLocal objClasseLocal = new WindowsFormsApplication1.classeLocal();
              atual = objClasseLocal.GetNomeFinal(wcfMockObject, "5");
              Assert.AreEqual(atual, esperado);
        }
    }
}
