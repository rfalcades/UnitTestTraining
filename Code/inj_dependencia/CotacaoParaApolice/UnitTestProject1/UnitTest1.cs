using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CotacaoParaApolice;
using Moq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Int32 esperado = 1;
            Int32 obtido;

            TrasformaCotacaoApolice transformacao = new TrasformaCotacaoApolice();
            Mock<ContratoCliente> objClienteMock = new Mock<ContratoCliente>();
             Mock<ContratoCotacao> objCotacaoMock = new Mock<ContratoCotacao>();
             objClienteMock.Setup(x => x.TestaCadastro(It.IsAny<Int32>())).Returns(true);
             objCotacaoMock.Setup(x => x.Getcotacao(It.IsAny<Int32>())).Returns(new Ocotacao()
                            {
                                nome = "Teste 1",
                                cpf = 1,
                                DataNasc = "10/10/11"
                            });
            objCotacaoMock.Setup(x => x.InsereNaBase(It.IsAny<Ocotacao>())).Returns(true);
            obtido = transformacao.TesteCotacao(10, objCotacaoMock.Object, objClienteMock.Object);
            Assert.AreEqual(esperado, obtido);
        }
    }
}
