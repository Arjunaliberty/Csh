using System;
using System.Collections.Generic;
using TabFunctionLibrary;

namespace ConsoleApp1
{
    class Program
    {

        delegate int[] GetFunctionLambda(int from, int to, int step);

        static void Main(string[] args)
        {
            int from;
            int to;
            int step;
            int[] buffer = null;
            TabFunctionExemplar tf = null;

            
            Console.Write("Введите начальное значения для вычисления функции: ");
            from = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите конечное значения для вычисления функции: ");
            to = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите шаг для вычисления функции: ");
            step = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\n\n\n");
            Console.WriteLine("Значения функция вычесленных с помощью экземплярного класса: \n");

            tf = new TabFunctionExemplar(from, to, step);
            Console.Write($"Значения квадра с диапазоном от {from} до {to} с шагом {step}: ");

            buffer = tf.FunctionSquare();

            for (int i = 0; i < buffer.Length; i++)
            {
                Console.Write($"{buffer[i]} ");
            }

            Console.WriteLine();

            Console.Write($"Значения куба с диапазоном от {from} до {to} с шагом {step}: ");
            buffer = tf.FunctionCube();
            for (int i = 0; i < buffer.Length; i++)
            {
                Console.Write($"{buffer[i]} ");
            }

            /*-------------------------------------------------------------------------------------*/

            Console.WriteLine("\n\n\n");
            Console.WriteLine("Значения функция вычесленных с помощью  лямбда - выражений: \n");

            Console.Write($"Значения квадра с диапазоном от {from} до {to} с шагом {step}: ");

            GetFunctionLambda FunctionSquare = (par1, par2, par3) => {
                                                                        List<int> buff = new List<int>();

                                                                        for (int i = from; i < to; i += step)
                                                                        {
                                                                            buff.Add(i * i);
                                                                        }
                                                                        return buff.ToArray();
                                                                    };

            buffer = FunctionSquare(from, to, step);

            for (int i = 0; i < buffer.Length; i++)
            {
                Console.Write($"{buffer[i]} ");
            }

            Console.WriteLine();

            GetFunctionLambda FunctionCube = (par1, par2, par3) => {
                                                                        List<int> buff = new List<int>();

                                                                        for (int i = from; i < to; i += step)
                                                                        {
                                                                            buff.Add(i * i * i);
                                                                        }
                                                                        return buff.ToArray();
                                                                    };

            Console.Write($"Значения куба с диапазоном от {from} до {to} с шагом {step}: ");
            buffer = FunctionCube(from, to, step);
            for (int i = 0; i < buffer.Length; i++)
            {
                Console.Write($"{buffer[i]} ");
            }
            
            Console.ReadLine();
        }
    }
}
