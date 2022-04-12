using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTest
{
    public class Geometry
    {
        /// <summary>
        /// Метод подсчёта площади круга по радиусу
        /// </summary>
        /// <param name="radius">Радиус окружности</param>
        /// <returns>Возвращает значение площади круга в виде числа с плавающей точкой</returns>
        public static double Square(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        /// <summary>
        /// Метод подсчёта площади треугольника по трём его сторонам
        /// </summary>
        /// <param name="a">Первая сторона</param>
        /// <param name="b">Вторая сторона</param>
        /// <param name="c">Третья сторона</param>
        /// <returns>Возвращает значение площади треугольника в виде числа с плавающей точкой</returns>
        public static double Square(double a, double b, double c)
        {
            double[] matrix = { a, b, c };
            for(int i = 0; i < 3; i++)
                for (int j = 0; j < 2; j++)
                {
                    if(matrix[j] > matrix[j +1])
                    {
                        double memory = matrix[j];
                        matrix[j] = matrix[j + 1];
                        matrix[j + 1] = memory;
                    }
                }
            if (Math.Pow(matrix[2], 2) == Math.Pow(matrix[0], 2) + Math.Pow(matrix[1], 2)) //по теореме пифагора
            {
                Console.WriteLine("Фигура с данными сторонами является прямоугольным треугольником");
                Console.ReadKey();
            }
            double p = (a + b + c) / 2;
            double square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return square;
        }
    }
}
