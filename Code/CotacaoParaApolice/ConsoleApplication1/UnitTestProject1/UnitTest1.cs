using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
using Moq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTestaCotacao()
        {
            Int32 esperado = 1;
            TransfereCotacaoApolice objTranscotacaoApolice = new TransfereCotacaoApolice();
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

            Int32 retorno = objTranscotacaoApolice.TestaCotacao(2, objCotacaoMock.Object, objClienteMock.Object);
            Assert.AreEqual(retorno, esperado);

        }
    }
}
