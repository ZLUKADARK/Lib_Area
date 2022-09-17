using System;
using System.Collections.Generic;
using System.Text;

namespace Lib_Area
{
    static class Figure
    {
        static double area;
        public static double getArea(float a)
        {
            return area;
        }
        public static double getArea(float a, float b)
        {
            if (a == b) 
            {
                Console.WriteLine("Фигура является: Квадратом");
            }
            else
            {
                Console.WriteLine("Фигура является: Прямоугольником");
            }

            area = a * b;
            return area;
        }
        public static double getArea(float a, float b, float c)
        {
           
            if (((a*a) == b*b + c*c) | (b*b == a*a + c*c) | (c*c == a*a + b*b))
            {
                Console.WriteLine("Треугольник является: Прямым");
            }
            else if ((a >= b + c) | (b >= a + c) | (c >= a + b))
            {
                Console.WriteLine("Треугольник является: Тупым");
            }
            else
            {
                Console.WriteLine("Треугольник является: Острым");
            }

            double p = (a + b + c) / 2;

            area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return area;
        }
    }
}
