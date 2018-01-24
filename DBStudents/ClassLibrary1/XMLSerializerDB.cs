using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace ClassLibrary1
{
    public class XMLSerializerDB :ISerializerDB
    {
        public String path { get; private set; }

        public XMLSerializerDB(String path)
        {
            this.path = path;
        }

        /// <summary>
        /// Метод для открытия в xml-файла
        /// </summary>
        /// <returns>Возвращает список элементов типа Student</returns>
        public List<Student> Load()
        {
            List<Student> st = new List<Student>();
            XmlSerializer xs = new XmlSerializer(typeof(List<Student>));

            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    st = (List<Student>)xs.Deserialize(fs);
                }
            }
            catch(IOException)
            {
                throw new IOException();
            }
            
            return st;
        }

        /// <summary>
        /// Метод для сохранения в xml-файл
        /// </summary>
        /// <param name="students">Список содержащий объекты типа Student</param>
        public void Save(List<Student> students)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Student>));

            try
            {
                using(FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    xs.Serialize(fs, students);
                }
            }
            catch (IOException)
            {
                throw new IOException();
            }
        }
    }
}
