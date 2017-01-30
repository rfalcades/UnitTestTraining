using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotacaoParaApolice
{
    public class CotacaoMock: ContratoCotacao
    {
        public Ocotacao Getcotacao(Int32 cpf)
        {
            Console.WriteLine("Não Fui no banco e peguei a cotacao");
            return new Ocotacao()
                            {
                                nome = "Teste 1",
                                cpf = 1,
                                DataNasc = "10/10/11"
                            };
        }




        public bool InsereNaBase(Ocotacao objCotacao)
        {
            Console.WriteLine("Recebe a cotação vai no banco pega mais dados insere a apolice no banco");
            return true;
        }
    }
}
