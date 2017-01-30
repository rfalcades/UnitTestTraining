using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotacaoParaApolice
{
    public interface ContratoCotacao
    {
       Ocotacao Getcotacao(Int32 cpf);
       bool InsereNaBase(Ocotacao objCotacao);
    }
}
