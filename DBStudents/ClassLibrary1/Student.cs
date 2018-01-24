using System;
using System.Runtime.Serialization;

namespace ClassLibrary1
{
    /// <summary>
    /// Аннотация необходимая для сереализации в xml-file
    /// </summary>
    [Serializable]
    /// <summary>
    /// Аннотация необходимая для сереализации в json-file
    /// </summary>
    [DataContract]
    public class Student
    {
        [DataMember]
        public string familyName { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public int age { get; set; }
        [DataMember]
        public Group group { get; set; }

        public Student()
        {
            familyName = "";
            name = "";
            age = 0;
            group = null;
        }

        public Student(String familyName, String name, int age, String nameGroup, int kurs)
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
