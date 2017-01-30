using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Cliente:ContratoCliente
    {
        public bool TestaCadastro(Int32 Cpf)
        {
            //vai no banco e me retorna se o cliente ta aprovado ou não
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
