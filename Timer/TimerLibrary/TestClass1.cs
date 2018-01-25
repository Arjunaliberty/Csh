using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerLibrary
{
    public class TestClass1
    {
       private static string name = "TestClass1";

       /// <summary>
       /// Типы обработчика события и события обязательно должны совпадать
       /// </summary>
       public TimerEvent showMessage = (sender, e) =>
                                       {
                                          Console.WriteLine($"{name}: {e.message}");
                                       }; 

        public TestClass1() { }
    }
}
