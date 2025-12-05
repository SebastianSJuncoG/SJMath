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
        public static double MultipleSum(List<double> Values)
        {
            double response = 0.0;
            foreach (double item in Values)
            {
                response = response + item;
            }

            return response;
        }

        /// <summary>
        /// Permite restar todos los números que se encuentren en la lista
        /// </summary>
        /// <param name="Values">Lista de números</param>
        /// <returns>El resultado entre la resta de todos los números de la lista</returns>
        public static double MultipleSubtraction(List<double> Values)
        {
            double response = 0.0;
            foreach (double item in Values)
            {
                response = response - item;
            }

            return response;
        }

        /// <summary>
        /// Permite multiplicar todos los números que se encuentren en la lista
        /// </summary>
        /// <param name="Values">Lista de números</param>
        /// <returns>El resultado entre la multiplicación de todos los números de la lista</returns>
        public static double MultipleMultiplication(List<double> Values)
        {
            double response = 0.0;
            foreach (double item in Values)
            {
                response = response * item;
            }

            return response;
        }

        /// <summary>
        /// Permite dividir todos los números que se encuentren en la lista
        /// </summary>
        /// <param name="Values">Lista de números</param>
        /// <returns>El resultado entre la división de todos los números de la lista</returns>
        public static double MultipleDivision(List<double> Values)
        {
            double response = 0.0;
            foreach (double item in Values)
            {
                response = response * item;
            }

            return response;
        }
    }
}
