using SJMath.Models;
using SJMath.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJMath.Geometry
{
    public static class _2DFigures
    {
        #region Cuadrado
        /// <summary>
        /// Permite calcular el area de un cuadrado
        /// </summary>
        /// <param name="part">Lado del cuadrado</param>
        /// <returns>El area del cuadrado</returns>
        public static double SquareArea(double part)
        {
            double result = 0;
            if (part == 0) return result;

            result = Arithmetic.SimpleMultiplication(part, part);

            return result;
        }

        /// <summary>
        /// Permite calcular el perimetro de de un cuadrado
        /// </summary>
        /// <param name="part">Lado del cuadrado</param>
        /// <returns>El perimetro del cuadrado</returns>
        public static double SquarePerimeter(double part)
        {
            double result = 0;
            result = Arithmetic.SimpleMultiplication(part, 4);

            return result;
        }

        /// <summary>
        /// Permite calcular la diagonal interna de un cuadrado
        /// </summary>
        /// <param name="part">Lado del cuadrado</param>
        /// <returns>La diagonal interna de un cuadrado</returns>
        public static double DiagonalSquare(double part)
        {
            double result = part * Arithmetic.SquareRoot(part);

            return result;
        }
        #endregion

        #region Rectangulo
        /// <summary>
        /// Permite calcular el area de un rectangulo
        /// </summary>
        /// <param name="high">Alto del rectangulo</param>
        /// <param name="width">Ancho del rectangulo</param>
        /// <returns>El area del rectangulo</returns>
        public static double RectangleArea(double high, double width)
        {
            double result = (Arithmetic.SimpleMultiplication(2, high) + Arithmetic.SimpleMultiplication(2, width));

            return result;
        }

        /// <summary>
        /// Permite calcular el perimetro de un rectangulo
        /// </summary>
        /// <param name="high">Alto del rectangulo</param>
        /// <param name="width">Ancho del rectangulo</param>
        /// <returns>El perimetro de un rectangulo</returns>
        public static double RectanglePerimeter(double high, double width)
        {
            double result = Arithmetic.SimpleMultiplication(2, (high + width));

            return result;
        }

        /// <summary>
        /// permite calcular la diagonal de un rectangulo
        /// </summary>
        /// <param name="high">Alto del rectangulo</param>
        /// <param name="width">Ancho del rectangulo</param>
        /// <returns>La diagonal de un rectangulo</returns>
        public static double DiagonalRectangle(double high, double width)
        {
            double result = Arithmetic.SimpleExponent(high, 2) + Arithmetic.SimpleExponent(width, 2);

            return Arithmetic.SquareRoot(result);
        }
        #endregion
    }
}
