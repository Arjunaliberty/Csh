using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CascadeCalculationsLibrary
{
    public class ThirdCascade
    {
        public delegate bool Check(int value);
        public event Check Stop;

        public ThirdCascade()
        {
            
        }

        public int Calculate(int value)
        {
            if (!Stop(value))
            {
                return value + 3;
            }
            else
            {
                return value;
            }
        }
    }
}
