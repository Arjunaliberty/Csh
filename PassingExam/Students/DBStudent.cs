using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace PassingExamLibrary
{
    public class DBStudent
    {
        public List<Student> students { get; private set; }

        public DBStudent(List<Student> students)
        {
            this.students = students;
        }

        public void SaveStudents(string fileName)
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Student>));

            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, students);
            }
        }

        public List<Student> LoadStudents(string fileName)
        {
            List<Student> students = null;
            XmlSerializer xml = new XmlSerializer(typeof(List<Student>));

            using(FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                students = (List<Student>)xml.Deserialize(fs);
            }

            return students;
        }
    }
}
