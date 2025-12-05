using SJMath.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

        /// <summary>
        /// Permite sumar todos los números que se encuentren en la lista
        /// </summary>
        /// <param name="Values">Lista de números</param>
        /// <returns>El resultado entre la suma de todos los números de la lista</returns>
        public static double MultipleSum(List<MultipleNumbersModel> Values)
        {
            MultipleNumbersModel multipleNumbersModel = new MultipleNumbersModel();
            multipleNumbersModel.number = 0.0;

            foreach (MultipleNumbersModel item in Values)
            {
                multipleNumbersModel.number = multipleNumbersModel.number + item.number;
            }

            return multipleNumbersModel.number;
        }

        /// <summary>
        /// Permite restar todos los números que se encuentren en la lista
        /// </summary>
        /// <param name="Values">Lista de números</param>
        /// <returns>El resultado entre la resta de todos los números de la lista</returns>
        public static double MultipleSubtraction(List<MultipleNumbersModel> Values)
        {
            MultipleNumbersModel multipleNumbersModel = new MultipleNumbersModel();
            multipleNumbersModel.number = 0.0;
            foreach (MultipleNumbersModel item in Values)
            {
                multipleNumbersModel.number = multipleNumbersModel.number - item.number;
            }

            return multipleNumbersModel.number;
        }

        /// <summary>
        /// Permite multiplicar todos los números que se encuentren en la lista
        /// </summary>
        /// <param name="Values">Lista de números</param>
        /// <returns>El resultado entre la multiplicación de todos los números de la lista</returns>
        public static double MultipleMultiplication(List<MultipleNumbersModel> Values)
        {
            MultipleNumbersModel multipleNumbersModel = new MultipleNumbersModel();
            multipleNumbersModel.number = 0.0;
            foreach (MultipleNumbersModel item in Values)
            {
                multipleNumbersModel.number = multipleNumbersModel.number * item.number;
            }

            return multipleNumbersModel.number;
        }

        /// <summary>
        /// Permite dividir todos los números que se encuentren en la lista
        /// </summary>
        /// <param name="Values">Lista de números</param>
        /// <returns>El resultado entre la división de todos los números de la lista</returns>
        public static double MultipleDivision(List<MultipleNumbersModel> Values)
        {
            MultipleNumbersModel multipleNumbersModel = new MultipleNumbersModel();
            multipleNumbersModel.number = 0.0;
            foreach (MultipleNumbersModel item in Values)
            {
                multipleNumbersModel.number = multipleNumbersModel.number / item.number;
            }

            return multipleNumbersModel.number;
        }

        /// <summary>
        /// Permite elevar a la n potencia un valor
        /// </summary>
        /// <param name="numberBase">Base</param>
        /// <param name="exponent">Exponente</param>
        /// <returns>El resultado de X^n</returns>
        public static double SimpleExponent(double numberBase, int exponent)
        {
            double result = 0;
            if (exponent == 0 || numberBase == 0) return result;

            result = numberBase;

            for (int i = 0; i <= exponent; i++)
            {
                result = result * numberBase;
            }

            return result;
        }
    }
}
