using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotacaoParaApolice
{
    public class Cliente : ContratoCliente
    {
        public bool TestaCadastro(Int32 Cpf)
        {
            if (Cpf == 1)
            {
                return false;
            }
            else
                if (Cpf == 2)
                {
                    return true;
                }
            return false;


        }

    }
}
