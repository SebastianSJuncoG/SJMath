using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJMath.Utilities
{
    public static class Arithmetic
    {
        /// <summary>
        /// Permite sumar 2 números
        /// </summary>
        /// <param name="x1">Primer número</param>
        /// <param name="x2">Segundo número</param>
        /// <returns>El resultado entre la suma de los 2 números recibidos.</returns>
        public static double SimpleSum(double x1, double x2)
        {
            return x1 + x2;
        }

        /// <summary>
        /// Permite restar 2 números
        /// </summary>
        /// <param name="x1">Primer número</param>
        /// <param name="x2">Segundo número</param>
        /// <returns>El resultado entre la resta de los 2 números recibidos.</returns>
        public static double SimpleSubtraction(double x1, double x2)
        {
            return x1 - x2;
        }

        /// <summary>
        /// Permite multiplicar 2 números
        /// </summary>
        /// <param name="x1">Primer número</param>
        /// <param name="x2">Segundo número</param>
        /// <returns>El resultado entre la multiplicación de los 2 números recibidos.</returns>
        public static double SimpleMultiplication(double x1, double x2)
        {
            return x1 * x2;
        }

        /// <summary>
        /// Permite dividir 2 números
        /// </summary>
        /// <param name="x1">Primer número</param>
        /// <param name="x2">Segundo número</param>
        /// <returns>El resultado entre la división de los 2 números recibidos.</returns>
        public static double SimpleDivision(double x1, double x2)
        {
            return x1 / x2;
        }
    }
}
