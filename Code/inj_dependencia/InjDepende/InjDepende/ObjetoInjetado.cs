using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjDepende
{
    public class ObjetoInjetado : InterfaceParaInjetar
    {
        public ObjetoInjetado()
        {

            Nome = "teste de nome";
            Pontos = 1;

        }
        public string GetNome()
        {
            return Nome;
        }
        public Int32 GetPontos()
        {
            return Pontos;
        }
        private string Nome;
        private Int32 Pontos;
    }
}
