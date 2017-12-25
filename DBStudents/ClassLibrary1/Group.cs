using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Group
    {
        public string name { get; set; }
        public int kurs { get; set; }

        public Group()
        {
            name = "";
            kurs = 0;
        }

        public Group (string name, int kurs)
        {
            this.name = name;
            this.kurs = kurs;
        }
    }
}
