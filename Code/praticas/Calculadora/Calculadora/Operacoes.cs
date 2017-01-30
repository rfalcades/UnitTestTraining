using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Calculadora
{
    public class Operacoes
    {
        public double somar(double x, double y)
        {
            return x + y;
        }
        public double subtrair(double x, double y)
        {
            return x - y;
        }
        public double multiplicar(double x, double y)
        {
            return x * y;
        }

        public double dividir(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Divisão por zero");
            }
            return x / y;
        }

        private double potencia(double x, double y)
        {
            return Math.Pow(x , y);
        }

        private static double raiz(double x)
        {
            return Math.Sqrt(x);
        }

        public Int32[] numerosprimos()
        {
            return new Int32[] {1,3,5,7,11};
        }

        public string valormoeda(double x)
        {
            return x.ToString("C", new CultureInfo("pt-BR"));
        }


        public double fatorial(double x)
        {
            return x.Equals(1)?x:x*fatorial(x-1);
        }
    }
}
