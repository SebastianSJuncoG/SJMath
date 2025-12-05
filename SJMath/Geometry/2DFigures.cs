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
            if (part == 0) return result;

            List<MultipleNumbersModel> multipleNumbersModel = new List<MultipleNumbersModel>();
            multipleNumbersModel = new List<MultipleNumbersModel> {
                new MultipleNumbersModel { number = part },
                new MultipleNumbersModel { number = part },
                new MultipleNumbersModel { number = part },
                new MultipleNumbersModel { number = part }
            };

            multipleNumbersModel.AddRange(multipleNumbersModel);
            result = Arithmetic.MultipleSum(multipleNumbersModel);

            return result;
        }
    }
}
