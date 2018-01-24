using System.Collections.Generic;

namespace TabFunctionLibrary
{
    public class TabFunctionExemplar
    {
        public int from { get; private set; }
        public int to { get; private set; }
        public int step { get; private set; }

public TabFunctionExemplar(int from, int to, int step)
        {
            this.from = from;
            this.to = to;
            this.step = step;
        }

        public int[] FunctionSquare()
        {
            List<int> buffer = new List<int>();
            

            for (int i = from; i < to; i += step)
            {
                buffer.Add(i * i);
            }

            return buffer.ToArray();
        }

        public int[] FunctionCube()
        {
            List<int> buffer = new List<int>();


            for (int i = from; i < to; i += step)
            {
                buffer.Add(i * i * i);
            }

            return buffer.ToArray();
        }



    }
}
