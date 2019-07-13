using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCalc04
{
    /// <summary>
    /// Interface de Calculadora
    /// </summary>
    public interface ICalculadora
    {
        /// <summary>
        /// Soma Valor
        /// </summary>
        /// <param name="valor1"></param>
        /// <param name="valor2"></param>
        double Soma(double valor1,double valor2);
        /// <summary>
        /// Subtrai Valor
        /// </summary>
        /// <param name="valor1"></param>
        /// <param name="valor2"></param>
        double Subtra(double valor1, double valor2);
        /// <summary>
        /// Multiplica Valor
        /// </summary>
        /// <param name="valor1"></param>
        /// <param name="valor2"></param>
        double Multi(double valor1, double valor2);
        /// <summary>
        /// Divide Valor
        /// </summary>
        /// <param name="valor1"></param>
        /// <param name="valor2"></param>
        double Divi(double valor1, double valor2);
        /// <summary>
        /// Soma 3 Valores
        /// </summary>
        /// <param name="valor1"></param>
        /// <param name="valor2"></param>
        /// <param name="valor3"></param>
        /// <returns></returns>
        double Soma(double valor1, double valor2, double valor3);
    }
}
