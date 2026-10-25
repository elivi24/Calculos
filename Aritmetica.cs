using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    internal class Aritmetica
    {
        /// <summary>
        /// Tipo de conversão de temperatura a executar
        /// </summary>
        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }
        /// <summary>
        /// Operação soma.
        /// </summary>
        /// <returns>Retorna a soma de dois números.</returns>
        public int Somar(int x, int y)
        {
            return x + y;
        }
        /// <summary>
        /// Operação subtrair.
        /// </summary>
        /// <returns>Retorna a subtração de dois números.</returns>
        public int Subtrair(int x, int y)
        {
            return x - y;
        }

        public double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
            {
                return (temperatura * 18000 + 32);
            }
            else if ()
            {
                return ((temperatura - 32) / 18000);
            }
            return -1;

        }
    }
}
