using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reposVector
{
    public struct Coord
    {
        public double x;
        public double y;
        public double z;

        public Coord(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
    public class Vector
    {
        public Coord v;
        public Vector(Coord v)
        {
            this.v = v;
        }

        // функция для сложения двух векторов
        public static Vector operator +(Vector a, Vector b)
        {
            Coord n = new Coord((a.v.x + b.v.x), (a.v.y + b.v.y), (a.v.z + b.v.z));
            return new Vector(n);
        }

        // функция для вычитания двух векторов
        public static Vector operator -(Vector a, Vector b)
        {
            Coord n = new Coord((a.v.x - b.v.x), (a.v.y - b.v.y), (a.v.z - b.v.z));
            return new Vector(n);
        }

        // функция произведения вектора на скаляр
        public static Vector operator *(Vector a, double k)
        {
            Coord n = new Coord((a.v.x * k), (a.v.y * k), (a.v.z * k));
            return new Vector(n);
        }

        // длина вектора
        public static Vector operator *(double k, Vector a)
        {
            Coord n = new Coord((a.v.x * k), (a.v.y * k), (a.v.z * k));
            return new Vector(n);
        }

        public double VectorLen()
        {
            return Math.Sqrt((Math.Pow(v.x, 2)) + (Math.Pow(v.y, 2)) + (Math.Pow(v.z, 2)));
        }
    }
}
