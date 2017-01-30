using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjDepende
{
    class Program
    {
        static void Main(string[] args)
        {
            RececeInjetado calculo = new RececeInjetado();

            Console.WriteLine(calculo.Calcular(3));

            ObjetoInjetado objInjetado = new ObjetoInjetado();
            Console.WriteLine(calculo.Calcular(3, objInjetado));

            InterfaceParaInjetar InterfaceAluno = new ObjetoInjetado();

            Console.WriteLine(calculo.Calcular(3, InterfaceAluno));

            InterfaceParaInjetar InterfaceAlunoMock = new ObjetoMock();

            Console.WriteLine(calculo.Calcular(3, InterfaceAlunoMock));

            Console.ReadLine();
        }
    }
}
