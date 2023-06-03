using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Vector
    {
        private double[] coordinate;

        public double[] Coordinates { get => coordinate; }
        public Vector(params double[] coordinates)
        {
            coordinate = coordinates;
        }
        public static double operator +(Vector vector1, Vector vector2)
        {
            double result = 0;
            foreach (var item in vector1.Coordinates)
            {
                if (item < 0) result += item;
            }
            foreach (var item in vector2.Coordinates)
            {
                if (item < 0) result += item;
            }
            return result;
        }

        public static double operator *(Vector vector1, Vector vector2)
        {
            double res = 1;
            for (int i = 0; i < vector1.Coordinates.Length; i += 2)
            {
                res *= vector1.Coordinates[i];
            }
            for (int i = 0; i < vector2.Coordinates.Length; i += 2)
            {
                res *= vector2.Coordinates[i];
            }

            return res;
        }

        public static int operator /(Vector vector1, Vector vector2)
        {
            int result = 0;
            foreach (var item in vector1.Coordinates)
            {
                if (item == 0) result++;
            }
            foreach (var item in vector2.Coordinates)
            {
                if (item == 0) result++;
            }
            return result;
        }

    }
}
