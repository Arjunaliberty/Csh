using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CascadeCalculationsLibrary
{
    public class SecondCascade
    {
        public delegate bool Check(int value);
        public event Check Stop;

        public SecondCascade()
        {

        }

        public int Calculate(int value)
        {
            if (!Stop(value))
            {
                return value + 2;
            }
            else
            {
                return value;
            }
        }
    }
}
