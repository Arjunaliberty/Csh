using reposVector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VectorProgramm
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector[] vectors = new Vector[2];
            Vector resultVector;
            double x, y, z, k;
            

            for(int i = 0; i < vectors.Length; i++)
            {
                Console.Write("Введите коодинату x {0} вектора: ", i + 1);
                x = Double.Parse(Console.ReadLine());
                Console.Write("Введите коодинату y {0} вектора: ", i + 1);
                y = Double.Parse(Console.ReadLine());
                Console.Write("Введите коодинату z {0} вектора: ", i + 1);
                z = Double.Parse(Console.ReadLine());
                Console.WriteLine();

                Coord coord = new Coord(x, y, z);
                vectors[i] = new Vector(coord); 
            }

            Console.WriteLine("Длина первого вектора равна {0}", vectors[0].VectorLen());
            Console.WriteLine("Длина второго вектора равна {0}", vectors[1].VectorLen());

            resultVector = vectors[0] + vectors[1];
            Console.WriteLine("Сложение двух векторов дает третий вектор с координатами x: {0}, y: {1}, z: {2}", resultVector.v.x, resultVector.v.y, resultVector.v.z);
            Console.WriteLine("Длина вектора после сложения двух векторов равна {0}", resultVector.VectorLen());

            resultVector = vectors[0] - vectors[1];
            Console.WriteLine("Разность двух векторов дает третий вектор с координатами x: {0}, y: {1}, z: {2}", resultVector.v.x, resultVector.v.y, resultVector.v.z);
            Console.WriteLine("Длина вектора после разности двух векторов равна {0}", resultVector.VectorLen());

            Console.Write("Введите число для умножения на первый вектор: ");
            k = Double.Parse(Console.ReadLine());
            resultVector = vectors[0] * k;
            Console.WriteLine("Произведение первого вектора на число дает третий вектор с координатами x: {0}, y: {1}, z: {2}", resultVector.v.x, resultVector.v.y, resultVector.v.z);
            Console.WriteLine("Длина первого вектора после умножения на число равна {0}", resultVector.VectorLen());

            Console.Write("Введите число для умножения на второй вектор: ");
            k = Double.Parse(Console.ReadLine());
            resultVector = vectors[1] * k;
            Console.WriteLine("Произведение второго вектора на число дает третий вектор с координатами x: {0}, y: {1}, z: {2}", resultVector.v.x, resultVector.v.y, resultVector.v.z);
            Console.WriteLine("Длина второго вектора после умножения на число равна {0}", resultVector.VectorLen());


            Console.ReadLine();
        }
    }
}
