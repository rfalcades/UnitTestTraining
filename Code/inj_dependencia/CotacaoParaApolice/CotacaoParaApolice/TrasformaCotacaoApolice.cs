using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotacaoParaApolice
{
    public class TrasformaCotacaoApolice
    {
        public Int32 TesteCotacao(Int32 cpf, ContratoCotacao objCotacao, ContratoCliente objCliente)
        {

            var cotacao = objCotacao.Getcotacao(cpf);

            if (objCliente.TestaCadastro(cotacao.cpf))
            {
                objCotacao.InsereNaBase(cotacao);
                Console.WriteLine("Seguro aceito com sucesso");
                return 1;
            }
            else
            {
                Console.WriteLine("O cliente não pode ter seguro");
                return 0;
            }
        }
    }
}

