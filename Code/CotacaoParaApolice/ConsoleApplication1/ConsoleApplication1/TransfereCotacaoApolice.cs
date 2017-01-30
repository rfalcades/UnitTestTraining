using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class TransfereCotacaoApolice
    {
        public Int32 TestaCotacao(Int32 cpf, ContratoCotacao objCotacao, ContratoCliente objCliente)
        {
            var objCot = objCotacao.Getcotacao(cpf);
            
            if (objCliente.TestaCadastro(cpf))
            {
                objCotacao.InsereNaBase(objCot);
                Console.WriteLine("Inseriu no banco");
                return 1;
            }
            return 0;
            
        }

  
    }
}
