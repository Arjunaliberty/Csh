using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CascadeCalculationsLibrary;

namespace CascadeCalculationsApp
{
    class Program
    {
        public const int INIT_VALUE_CHECK = 1000;

        static void Main(string[] args)
        {
            int value = 0;

            FirstCascade fc = new FirstCascade();
            SecondCascade sc = new SecondCascade();
            ThirdCascade tc = new ThirdCascade();

            fc.Stop += CheckFunction;
            sc.Stop += CheckFunction;
            tc.Stop += CheckFunction;


            for (int i = 0; i < 10000; i++)
            {
                value = tc.Calculate(sc.Calculate(fc.Calculate(value)));
            }

            Console.WriteLine($"Значения каскадного вычисления функций равно: {value}");
            Console.ReadLine();
        }

        private static bool CheckFunction(int value)
        {
           return value >= INIT_VALUE_CHECK ? true : false;
        }
    }
}
