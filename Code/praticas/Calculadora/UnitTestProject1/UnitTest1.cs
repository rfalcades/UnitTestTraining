using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculadora;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSomar()
        {   
            Operacoes op = new Operacoes();
            double esperado = 12;
            double x = 10;
            double y = 2;
            double obtido = op.somar(x,y);
            Assert.AreEqual(esperado,obtido);
        }

        [TestMethod]
        public void TestSubtrair()
        {
            Operacoes op = new Operacoes();
            double esperado = 5;
            double x = 12;
            double y = 7;
            double obtido = op.subtrair(x, y);
            Assert.AreEqual(esperado, obtido);
        }
        [TestMethod]
        [Ignore]
        [Priority(1)] //Bild
        [TestCategory("Carga")]
        [Owner("Gorayb")]
        [WorkItem(222)] // Este teste está relacionado com o bug 222
        [Description("Este teste faz parte da multiplicação")]
        public void TestMultiplicar()
        {
            Operacoes op = new Operacoes();
            double esperado = 14;
            double x = 7;
            double y = 2;
            double obtido = op.multiplicar(x, y);
            Assert.AreEqual(esperado, obtido);           
        }
        [TestMethod]
        public void TestDividir()
        {
            Operacoes op = new Operacoes();
            double esperado = 3;
            double x = 9;
            double y = 3;
            double obtido = op.dividir(x, y);
            Assert.AreEqual(esperado, obtido);
            //Assert.Inconclusive("Testar a divisão por zero");
        }
        //Este ultimo teste é um exemplo de Code Coverage
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDividirZero()
        {
            Operacoes op = new Operacoes();
            double x = 9;
            double y = 0;
            double obtido = op.dividir(x, y);
        }
 
        [TestMethod]
        public void TestPotencia()
        {   //Privado
            Operacoes op = new Operacoes();
            PrivateObject privObj = new PrivateObject(op);

            double esperado = 64;
            double x = 4;
            double y = 3;
            double obtido = (double)privObj.Invoke("potencia", x, y);
            Assert.AreEqual(esperado, obtido);
        }

        [TestMethod]
        public void TestRaiz()
        {   //Privado e statico
            PrivateType privObj = new PrivateType(typeof(Operacoes));
            double esperado = 3;
            double x = 9;
            double obtido = (double)privObj.InvokeStatic("raiz", x);
            Assert.AreEqual(esperado, obtido);
        }

        [TestMethod]
        public void TestNumerosprimos()
        {
            Operacoes op = new Operacoes();
            Int32[] esperado = new Int32[] { 1, 3, 5, 7, 11 };
            Int32[] obtido = op.numerosprimos();
            CollectionAssert.AreEqual(esperado, obtido);
            //CollectionAssert.AreEquivalent ordem diferente na coleção
            //CollectionAssert.IsSubsetOf uma coleção é subconjunto da outra
            //CollectionAssert.Contains contém um determinado valor
            //CollectionAssert.AllItemsAreUnique todos os elementos são unicos
          }

        [TestMethod]
        public void TestValormoeda()
        {
            Operacoes op = new Operacoes();
            double x = 25.50;
            string esperado = "R$ 25,50";
            string obtido = op.valormoeda(x);
            StringAssert.Equals(esperado, obtido);
            //StringAssert.StartsWith começa com
            //StringAssert.Matches expressão regular
            //StringAssert.Contains contem um valor

        }
    }
}
