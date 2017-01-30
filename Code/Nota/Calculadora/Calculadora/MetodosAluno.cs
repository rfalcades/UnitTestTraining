using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class MetodosAluno : InterfaceAluno
    {
        ClasseAluno InterfaceAluno.GetAluno(string cod_aluno)
        {
            return new ClasseAluno()
           {
               cod_aluno = "1",
               nome = "Gorayb",
               pontos = 2
           };
        }
    }
}
