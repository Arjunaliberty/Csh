using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ClassLibrary1
{
    public class ContextDB
    {
        List<Student> students = new List<Student>();
        FileStream fs;
        int curStudent = -1;

        public ContextDB()
        {
            
        }

        public void Add(string familyName, string name, int age, string nameGroup, int kurs)
        {
            students.Add(new Student(familyName,name,age,nameGroup,kurs));
            curStudent = students.Count - 1;
        }

        public void Edit(Student find, Student replace)
        {
            int index = students.IndexOf(find);
            students[index] = replace;
        }

        private void Remove(Student stdnt)
        {
            students.Remove(stdnt);
            curStudent = students.Count - 1;
        }

        public void Remove()
        {
            Student stdnt = students[curStudent];
            Remove(stdnt);
        }

        public void LoadTXT(String path)
        {
            try
            {
                using(StreamReader sr = new StreamReader(File.OpenRead(path)))
                {
                    String line = null;
                    String[] buffer = null;

                    while((line = sr.ReadLine()) != null)
                    {
                        buffer = line.Split(' ');

                        if (buffer.Length != 5)
                        {
                            throw new Exception();
                        }

                        students.Add(new Student(buffer[0], buffer[1], Convert.ToInt32(buffer[2]), buffer[3], Convert.ToInt32(buffer[4])));

                    }
                    curStudent = students.Count - 1;
                }
            }
            catch (Exception)
            {
                throw new InvalidFormatDataBaseException("Неверный формат данных в базе!"); 
            }
        }

        public void SaveTXT(String path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(File.OpenWrite(path)))
                {
                    foreach (Student st  in students)
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

        public void Next()
        {
            if(curStudent < students.Count() - 1)
            {
                curStudent++;
            }        
        }

        public void Prev()
        {
            if(curStudent > 0)
            {
                curStudent--;
            }
        }

        public Student GetCurStudent()
        {
            return students[curStudent];
        }

        public Student[] GetStudents()
        {
            return students.ToArray();
        }

        public void SetCurStudent(Student stdnt)
        {
            curStudent=students.IndexOf(stdnt);
        }
    }
}
