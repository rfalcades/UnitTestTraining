using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class objeto
    {
        public static Int32 contador { get; set; }
        public objeto(Int32 inicial)
        {
            if (contador == 0)
            {
                contador = inicial;
            }
        }
        public Int32 estoque(Int32 venda)
        {
            contador = contador - venda;
            return contador;
        }
    }
}
