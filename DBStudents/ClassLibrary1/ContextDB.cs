using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ClassLibrary1
{
    /// <summary>
    /// Перечесление определяющее тип файла для сохранения
    /// </summary>
    public enum TypeFile
    {
        txt,
        xml,
        json
    }

    public class ContextDB
    {
        List<Student> students = new List<Student>();
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

        public void Load(String path, TypeFile typeFile)
        {
            switch(typeFile)
            {
                case TypeFile.txt:
                    TextSerializerDB st = new TextSerializerDB(path);
                    students = st.Load();
                    curStudent = students.Count - 1;
                    break;
                case TypeFile.xml:
                    XMLSerializerDB xml = new XMLSerializerDB(path);
                    students = xml.Load();
                    curStudent = students.Count - 1;
                    break;
                case TypeFile.json:
                    JSONSerializerDB js = new JSONSerializerDB(path);
                    students = js.Load();
                    curStudent = students.Count - 1;
                    break;
            }
        }

        public void Save(String path, TypeFile typeFile)
        {
            switch (typeFile)
            {
                case TypeFile.txt:
                    TextSerializerDB st = new TextSerializerDB(path);
                    st.Save(students);
                    break;
                case TypeFile.xml:
                    XMLSerializerDB xml = new XMLSerializerDB(path);
                    xml.Save(students);
                    break;
                case TypeFile.json:
                    JSONSerializerDB js = new JSONSerializerDB(path);
                    js.Save(students);
                    break;
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
