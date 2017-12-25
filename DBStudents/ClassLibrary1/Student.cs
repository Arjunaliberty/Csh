using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Student
    {
        public string familyName { get; set; }
        public string name { get; set; }

        public int age { get; set; }

        public Group group { get; set; }

        public Student()
        {
            familyName = "";
            name = "";
            age = 0;
            group = null;
        }

        public Student(string familyName, string name, int age, 
            string nameGroup, int kurs)
        {
            this.familyName = familyName;
            this.name = name;
            this.age = age;
            group = new Group(nameGroup, kurs);
        }

        public override string ToString()
        {
            return familyName + " " + 
                   name + " " + 
                   age.ToString() + " " + 
                   group.name + " " +
                   group.kurs.ToString();
        }
    }
}
