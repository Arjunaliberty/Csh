using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimerLibrary;

namespace TimerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass1 tc1 = new TestClass1();
            TestClass2 tc2 = new TestClass2();
            TestClass3 tc3 = new TestClass3();

            Console.Write("Введите количество секунд для отсчета таймера: ");

            Timer timer = new Timer(Convert.ToInt32(Console.ReadLine()));

            timer.AddHandler(tc1.showMessage);
            timer.AddHandler(tc2.showMessage);
            timer.AddHandler(tc3.showMessage);

            timer.Start();

            Console.ReadLine();
        }
    }
}
