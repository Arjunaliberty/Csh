using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows;
            int colums;

            int[,] buffer = null;

            MatrixInt m1 = null;
            MatrixInt m2 = null;
            MatrixInt m3 = null;

            Random rnd = new Random();

            do
            {
                Console.Write("Введите количество строк первой матрицы начиная с 1: ");
                rows = Int32.Parse(Console.ReadLine());
            } while (rows == 0);

            do
            {
                Console.Write("Введите количество столбцов первой матрицы начиная с 1: ");
                colums = Int32.Parse(Console.ReadLine());
            } while (colums == 0);


            buffer = new int[rows, colums];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    buffer[i, j] = rnd.Next(0, 50);
                }
            }
            m1 = new MatrixInt(buffer);


            do
            {
                Console.Write("Введите количество строк второй матрицы начиная с 1: ");
                rows = Int32.Parse(Console.ReadLine());
            } while (rows == 0);

            do
            {
                Console.Write("Введите количество столбцов второй матрицы начиная с 1: ");
                colums = Int32.Parse(Console.ReadLine());
            } while (colums == 0);


            buffer = new int[rows, colums];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    buffer[i, j] = rnd.Next(0, 50);
                }
            }
            m2 = new MatrixInt(buffer);

            Console.WriteLine("\nПервая сгенрированная матрица: ");
            m1.ShowMatrix();

            Console.WriteLine("\nВторая сгенрированная матрица: ");
            m2.ShowMatrix();

            try
            {
                m3 = m1 + m2;
                Console.WriteLine("\nРезультирующая матрица после сложения первой и второй матрицы:");
                m3.ShowMatrix();

                m3 = m1 - m2;
                Console.WriteLine("\nРезультирующая матрица после вычитания первой и второй матрицы:");
                m3.ShowMatrix();

                m3 = m1 * m2;
                Console.WriteLine("\nРезультирующая матрица после умножения первой и второй матрицы:");
                m3.ShowMatrix();
            }
            catch (MatrixExcepction e)
            {
                Console.WriteLine("\n\nНе удалось произвести операции над матрицами!");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка: " + e.Message);
                Console.ResetColor();
                Console.WriteLine("Программа будет завершена!");
            }

            Console.ReadLine();
        }
    }
}
