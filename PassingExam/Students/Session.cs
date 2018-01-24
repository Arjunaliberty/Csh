using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingExamLibrary
{
    delegate bool PassExam(int x);
    public class Session
    {
        public List<Student> students { get; private set; }
        PassExam passExam = x => x >= 3;
        public Session(List<Student> students)
        {
            this.students = students;
        }

        /// <summary>
        /// Запускает начало сдачи сессии
        /// </summary>
        public void StartSession()
        {
            Random rnd = new Random();

            foreach (Student st in students)
            {
                foreach (Exam ex in st.exams)
                {
                    ex.result = rnd.Next(0, 5);
                }
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Student> StudentListPassExam()
        {
            List<Student> result = null;

            foreach (Student st in students)
            {
                foreach (Exam ex in st.exams)
                {
                    if (ex.result >= 3) result.Add(st);
                }
            }
            return result;
        }

        public List<Student> StudentListPassExamLambda()
        {
            List<Student> result = null;

            foreach (Student st in students)
            {
                foreach (Exam ex in st.exams)
                {
                    if (passExam(ex.result)) result.Add(st);
                }
            }
            return result;
        }
    }
}
