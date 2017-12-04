using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MatrixInt
    {
        private int[,] matrix = null;

        public MatrixInt(int[,] matrix)
        {
            this.matrix = matrix;
        }

        /// <summary>
        /// Метод для получения занчения из MatrixInt по указанным индексам
        /// </summary>
        /// <param name="i">Номер строки</param>
        /// <param name="j">Номер столбца</param>
        /// <returns>Возвращает значение лежащие по заданным индексам</returns>
        public int GetValue(int i, int j)
        {
            return matrix[i, j];
        }

        private int[,] GetMatrix()
        {
            return matrix;
        }

        /// <summary>
        /// Метод для получения количество строк типа MatrixInt
        /// </summary>
        /// <returns>Возвращает количество строк</returns>
        public int GetRows()
        {
            return matrix.GetUpperBound(0) + 1;
        }

        /// <summary>
        /// Метод для получения количество столбцов типа MatrixInt
        /// </summary>
        /// <returns>Возвращает количество столбцов</returns>
        public int GetColums()
        {
            return matrix.Length / GetRows();
        }

        /// <summary>
        /// Перегрузка оператора + для сложения типов MatrixInt
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        /// <exception cref=""></exception>
        public static MatrixInt operator + (MatrixInt left, MatrixInt right)
        {
            int rows;
            int colums;
            int[,] result = null;

            if (left.matrix.Length != right.matrix.Length)
            {
                throw new MatrixExcepction("Размер матриц должен быть одинаковый!");
            }

            if ( left == null || right == null)
            {
                throw new MatrixExcepction("Один или более параметров имеют значение null!");
            }

            // Определяе размерность матриц (количество столбцов)
            // метод GetUpperBound(0) возращает индекс последнего элемента в размерности 0
            rows = left.GetRows();
            colums = left.GetColums();

            result = new int[rows, colums];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    result[i, j] = left.GetValue(i, j) +  right.GetValue(i, j);
                }
            }
            
             return new MatrixInt(result);
        }

        /// <summary>
        /// Перегрузка оператора - для сложения типов MatrixInt
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        /// <exception cref=""></exception>
        public static MatrixInt operator - (MatrixInt left, MatrixInt right)
        {
            int rows;
            int colums;
            int[,] result = null;

            if (left.matrix.Length != right.matrix.Length)
            {
                throw new MatrixExcepction("Размер матриц должен быть одинаковый!");
            }

            if (left == null || right == null)
            {
                throw new MatrixExcepction("Один или более параметров имеют значение null!");
            }

            // Определяе размерность матриц (количество столбцов)
            // метод GetUpperBound(0) возращает индекс последнего элемента в размерности 0
            rows = left.GetRows();
            colums = left.GetColums();

            result = new int[rows, colums];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    result[i, j] = left.GetValue(i, j) - right.GetValue(i, j);
                }
            }

            return new MatrixInt(result);
        }

        /// <summary>
        /// Перегрузка оператора * для сложения типов MatrixInt
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        /// <exception cref=""></exception>
        public static MatrixInt operator * (MatrixInt left, MatrixInt right)
        {
            int rows;
            int colums;
            int[,] result = null;

            if (left.matrix.Length != right.matrix.Length)
            {
                throw new MatrixExcepction("Размер матриц должен быть одинаковый!");
            }

            if (left == null || right == null)
            {
                throw new MatrixExcepction("Один или более параметров имеют значение null!");
            }

            // Определяе размерность матриц (количество столбцов)
            // метод GetUpperBound(0) возращает индекс последнего элемента в размерности 0
            rows = left.GetRows();
            colums = left.GetColums();

            result = new int[rows, colums];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    result[i, j] = left.GetValue(i, j) * right.GetValue(i, j);
                }
            }

            return new MatrixInt(result);
        }

        /// <summary>
        /// Метод для вывода матрицы на экран
        /// </summary>
        public void ShowMatrix()
        {
            for (int i = 0; i < this.GetRows(); i++)
            {
                for (int j = 0; j < this.GetColums(); j++)
                {
                    Console.Write($"{this.GetValue(i, j):d4} ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Перегрузка метода Equals для сравнения матриц для передачи в качестве 
        /// параметров методуAssert.AreEqual в качестве параметров
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool flag = false;

            if (!(obj is MatrixInt))
            {
                flag = false;
            }
            else
            {
                for (int i = 0; i < GetRows(); i++)
                {
                    for (int j = 0; j < GetColums(); j++)
                    {
                        if (((MatrixInt)obj).GetValue(i, j) == GetValue(i, j))
                        {
                            flag = true;
                        }
                        else
                        {
                            flag = false;
                        }
                    }
                }
            }

            return flag;
        }
    }
}
