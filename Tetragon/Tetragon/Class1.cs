using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetragon
{
    enum TypeFigure
    {
        Square = 1,
        Rectangle,
        Rhombus,
        Parallelogram,
        Trapeze
    }
    public struct Point
    {
        public double x;
        public double y;

        Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Tetragon
    {

        private Point A;
        private Point B;
        private Point C;
        private Point D;

        public Tetragon(Point A, Point B, Point C, Point D)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
        }

        /* Вычисляем длины сторон четырехугольника */
        private double Len(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2));
        }

        private double Angel()
        {
            return 1;
        }

        public bool CheckParallelogram()
        {
            if ((Len(A, D) == Len(B, C)) && (Len(A, B) == Len(D, C)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       public bool CneckTrapeze()
        {
            if()
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /*
        public bool CheckExist()
        {
            if ((Len(A, B) < (Len(B, C) + Len(C, A))) && (Len(B, C) < (Len(A, B) + Len(C, A))) && (Len(C, A) < (Len(A, B) + Len(B, C))))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double P()
        {
            return Len(A, B) + Len(B, C) + Len(C, A);
        }

        public double S()
        {
            double p = P() / 2;
            return Math.Sqrt(p * (p - Len(A, B)) * (p - Len(B, C)) * (p - Len(C, A)));
        }*/

    }
}
