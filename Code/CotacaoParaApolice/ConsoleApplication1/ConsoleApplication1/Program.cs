using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            TransfereCotacaoApolice objTranscotacaoApolice = new TransfereCotacaoApolice();



            Cotacao objCotacao = new Cotacao();
            Cliente objCliente = new Cliente();
            objTranscotacaoApolice.TestaCotacao(2, objCotacao, objCliente);


            CotacaoMock objCotacaoMock = new CotacaoMock();
            ClienteMock objClienteMock = new ClienteMock();
            objTranscotacaoApolice.TestaCotacao(2, objCotacaoMock, objClienteMock);

        }
    }
}
