using System;
using System.Collections.Generic;
using System.IO;


namespace ClassLibrary1
{
    public class TextSerializerDB : ISerializerDB
    {
        public String path { get; private set; }

        public TextSerializerDB(String path)
        {
            this.path = path;
        }

        /// <summary>
        /// Метод для загрузки файла из txt-файла
        /// </summary>
        /// <param name="students">Список содержащий объекты типа Student</param>
        /// <param name="curStudent">Параметр возвращающий позицию текущего студента</param>
        public List<Student> Load()
        {
            String line = null;
            String[] buffer = null;
            List<Student> st = new List<Student>();

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        buffer = line.Split(' ');

                        if (buffer.Length != 5)
                        {
                            throw new Exception();
                        }

                        st.Add(new Student(buffer[0], buffer[1], Convert.ToInt32(buffer[2]), buffer[3], Convert.ToInt32(buffer[4])));
                    }
                }
            }
            catch (Exception)
            {
                throw new InvalidFormatDataBaseException("Неверный формат данных в базе!");
            }

            return st;
        }

        /// <summary>
        /// Метод для сохранения в txt-файл
        /// </summary>
        /// <param name="students">Список содержащий объекты типа Student</param>
        public void Save(List<Student> students)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    foreach (Student st in students)
                    {
                        sw.WriteLine(st.ToString());
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
