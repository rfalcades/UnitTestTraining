﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Cotacao:ContratoCotacao
    {
        public Ocotacao Getcotacao(Int32 cpf)
        {
            Console.WriteLine("Fui no banco e peguei a cotacao");
            if (cpf == 1)
            {
                return new Ocotacao()
                {
                    nome = "Teste 1",
                    cpf = 1,
                    DataNasc = "10/10/11"
                };
            }
            else if (cpf == 2)
            {
                return new Ocotacao()
                {
                    nome = "Teste 2",
                    cpf = 2,
                    DataNasc = "10/10/12"
                };
            }
            return null;
        }

        public bool InsereNaBase(Ocotacao objCot)
        {
            Console.WriteLine("Recebe a cotação vai no banco pega mais dados insere a apolice no banco");
            return true;
        }
    }
}
