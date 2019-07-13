using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCalc04
{
    public class Calculadora : ICalculadora
    {
        public double Divi(double valor1, double valor2)
        {
            return valor1 / valor2;
        }
        public double Soma(double valor1, double valor2, double valor3)
        {
            return valor1 + valor2 + valor3;
        }

        public double Multi(double valor1, double valor2)
        {
            return valor1 * valor2;
        }

        public double Soma(double valor1, double valor2)
        {
            return valor1 + valor2;
        }

        public double Subtra(double valor1, double valor2)
        {
            return valor1 - valor2;
        }
    }
}
