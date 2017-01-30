using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class ClasseCalculaNota
    {
        private readonly InterfaceAluno _ClasseAluno;

        public ClasseCalculaNota(InterfaceAluno ClasseAluno)
        {
            this._ClasseAluno = ClasseAluno;
        }

        public Int32 CalcularNota(string AlunoID, List<Int32> notas)
        {
            Int32 notaFinal = 0;

            ClasseAluno aluno = _ClasseAluno.GetAluno(AlunoID);
            notaFinal = aluno.pontos + notas[0] + notas[1];
            return notaFinal;

        }

    }
}
