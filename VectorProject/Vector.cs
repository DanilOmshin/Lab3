using System;

namespace VectorProject
{
    public class Vector
    {
        // свойства для чтения полей класса
        public double X { get; }
        public double Y { get; }
        public double Z { get; }

        // конструктор объектов класса "Вектор" с тремя параметрами
        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        // перегрузка опрератора + для сложения двух векторов
        public static Vector operator+(Vector l, Vector r)
        {
            return new Vector(l.X + r.X, l.Y + r.Y, l.Z + r.Z);
        }

        // перегрузка опрератора - для разности двух векторов
        public static Vector operator-(Vector l, Vector r)
        {
            return new Vector(l.X - r.X, l.Y - r.Y, l.Z - r.Z);
        }

        // перегрузка оператора * для скалярного произведения двух векторов
        public static double operator *(Vector l, Vector r)
        {
            return l.X * r.X + l.Y * r.Y + l.Z * r.Z;
        }

        // перегрузка оператора ^ для векторного произведения двух векторов
        public static Vector operator ^(Vector l, Vector r)
        {
            return new Vector(l.Y * r.Z - l.Z * r.Y, 
                              l.Z * r.X - l.X * r.Z, 
                              l.X * r.Y - l.Y * r.X);
        }

        // метод для нахождения длины вектора
        public double GetLength()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        // переопределённый метод родительского (Object) класса
        public override string ToString()
        {
            return "{" + X + ", " + Y + ", " + Z + "}";
        }

    }
}
