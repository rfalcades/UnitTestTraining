using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjDepende
{
    class RececeInjetado
    {
        public string Calcular(Int32 nota)
        {
            ObjetoInjetado Aluno = new ObjetoInjetado();
            return (Aluno.GetPontos() + nota).ToString();

        }

        public string Calcular(Int32 nota, ObjetoInjetado Aluno)
        {
            return (Aluno.GetPontos() + nota).ToString();
        }

        public string Calcular(Int32 nota, InterfaceParaInjetar Aluno)
        {
            return (Aluno.GetPontos() + nota).ToString();
        }

    }
}
