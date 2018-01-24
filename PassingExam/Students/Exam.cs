using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingExamLibrary
{
    public class Exam
    {
        /// <summary>
        /// Идентификатор экзамена
        /// </summary>
        public int id { get; private set; }
        /// <summary>
        /// Назваие экзамена
        /// </summary>
        public string name { get; private set; }
        /// <summary>
        /// Результат сдачи экзамена
        /// </summary>
        public int result { get; set; }

        public Exam(int id, string name)
        {
            this.id = 0;
            this.name = "";
            this.result = 0;
        }
        public Exam(int id, string name, int result)
        {
            this.id = id;
            this.name = name;
            this.result = result;
        }
    }
}
