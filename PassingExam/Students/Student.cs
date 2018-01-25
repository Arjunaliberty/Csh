using System;
using System.Collections.Generic;

namespace PassingExamLibrary
{
    [Serializable]
    public class Student
    {
        /// <summary>
        /// Имя студента
        /// </summary>
        public string name { get; private set; }
        /// <summary>
        /// Фамилия студента
        /// </summary>
        public string surname { get; private set; }
        /// <summary>
        /// Возраст студента
        /// </summary>
        public int age { get; private set; }
        /// <summary>
        /// Курс студента
        /// </summary>
        public int course { get; private set; }
        /// <summary>
        /// Список экзаменов сдающих студентом
        /// </summary>
        public List<Exam> exams { get; private set; }

        public Student(string name, string surname, int age, int course, List<Exam> exams)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.course = course;
            this.exams = exams;
        }
    }
}
