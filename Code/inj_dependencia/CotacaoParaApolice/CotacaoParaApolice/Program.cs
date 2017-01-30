using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotacaoParaApolice
{
    class Program
    {
        static void Main(string[] args)
        {
            TrasformaCotacaoApolice transformacao = new TrasformaCotacaoApolice();

            Cotacao objCotacao = new Cotacao();
            Cliente objCliente = new Cliente();
            transformacao.TesteCotacao(1, objCotacao, objCliente);

            CotacaoMock objCotacaoMock = new CotacaoMock();
            ClienteMock objClienteMock = new ClienteMock();
            transformacao.TesteCotacao(10, objCotacaoMock, objClienteMock);

            Console.ReadLine();
        }
    }
}
