using System;
using System.Collections.Generic;

namespace PassingExamLibrary
{
    public delegate bool CheckExam(Exam exam, int checkValue);
    public class Session
    {
        private List<Student> students;

        public CheckExam checkExamPassing = (exam, value) => exam.result >= value;
        public CheckExam checkExamNoPassing = (exam, value) => exam.result < value;

        public Session(List<Student> students)
        {
            this.students = students;
        }

        /// <summary>
        /// Метод для запуска сессии
        /// </summary>
        public void StartSession()
        {
            Random rnd = new Random();

            foreach (Student st in students)
            {
                foreach (Exam ex in st.exams)
                {
                    ex.result = (int)rnd.Next(0, 5);
                }
            }
        }

        /// <summary>
        /// Метод для отбора студентов сдавших экзамен
        /// </summary>
        /// <param name="nameExam">Название экзамена</param>
        /// <param name="checkValue">Проходной балл</param>
        /// <returns>Список студентов сдваших экзамен</returns>
        public List<Student> ListPassingStusents(string nameExam, int checkValue)
        {
            List<Student> result = null;
            foreach (Student st in students)
            {
                foreach (Exam ex in st.exams)
                {
                    if(nameExam == ex.nameExam)
                    {
                        if(checkExamPassing(ex, checkValue))
                        {
                            result.Add(st);
                        }
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Метод для отбора студентов не сдавших экзамен
        /// </summary>
        /// <param name="nameExam">Название экзамена</param>
        /// <param name="checkValue">Проходной балл</param>
        /// <returns>Список студентов не сдваших экзамен</returns>
        public List<Student> ListNoPassingStusents(string nameExam, int checkValue)
        {
            List<Student> result = null;
            foreach (Student st in students)
            {
                foreach (Exam ex in st.exams)
                {
                    if (nameExam == ex.nameExam)
                    {
                        if (checkExamNoPassing(ex, checkValue))
                        {
                            result.Add(st);
                        }
                    }
                }
            }

            return result;
        }

    }
}
