using System;
using System.Reflection.Metadata;

namespace GeometryLibrary
{
    public static class Geometry
    {
        public static double GetCircleArea(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Радиус не может быть отрицательным");
            }
            return Math.PI * radius * radius;
        }

        public static double GetRectangleArea(double side1, double side2)
        {
            if (side1 < 0 || side2 < 0)
            {
                throw new ArgumentException("Стороны прямоугольника не могут быть отрицательными");
            }
            return side1 * side2;
        }

        public static double GetTriangleArea(double side1, double side2, double side3)
        {
            if (side1 < 0 || side2 < 0 || side3 < 0)
            {
                throw new ArgumentException("Стороны треугольника не могут быть отрицательными");
            }
            double semiPerimeter = (side1 + side2 + side3) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));
        }

        public static double GetArea(double[] sides)
        {
            // если передана одна сторона считаем что это круг и передан только радиус
            if (sides.Length == 1)
            {
                return GetCircleArea(sides[0]);
            }
            // если переданы две стороны это прямоугольник
            else if (sides.Length == 2)
            {
                double length  = sides[0];
                double width = sides[1];

                //проверяем не квадрат ли входящая фигура
                if (length == width)
                {
                    return length * length;
                }

                else
                {
                    return GetRectangleArea(width, length);
                }
            }

            else if (sides.Length == 3)
            {
                double side1 = sides[0];
                double side2 = sides[1];
                double side3 = sides[2];

                // проверяем треугольник на условие a²+ b²=c² для понимания прямоугольный ли он
                if (side1 * side1 + side2 * side2 == side3 * side3 || side1 * side1 + side3 * side3 == side2 * side2 || side2 * side2 + side3 * side3 == side1 * side1)
                {                           
                    return (side1 * side2) / 2;
                }
                else
                {
                    // the triangle is not right-angled
                    return GetTriangleArea(side1, side2, side3);
                }
            }
            else
            {
                throw new ArgumentException("Для других фигур методы не написаны, возвращайтесь к нам позже =)");
            }
        }
    }
}