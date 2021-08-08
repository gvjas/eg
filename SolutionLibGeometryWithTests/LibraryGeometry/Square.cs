using System;

namespace LibraryGeometry
{
    public static class Square
    {
        public static double Сircle(double radius)
        {
            if (radius <= 0) return double.NaN;
            return Math.PI * radius * radius;
        }

        public static double Triangle(double a, double b, double c)
        {
            if (!IsTriangle(a, b, c)) return double.NaN;
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public static bool IsTriangle(double a, double b, double c)
        {
            return a > 0 && b > 0 && c > 0 && (a + b > c) && (a + c > b) && (b + c > a);
        }

        public static bool IsRightTriangle(double a, double b, double c)
        {
            return IsTriangle(a, b, c) && (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b);
        }
    }
}