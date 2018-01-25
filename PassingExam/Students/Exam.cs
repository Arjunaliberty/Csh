namespace PassingExamLibrary
{
    public class Exam
    {
        /// <summary>
        /// Назваие экзамена
        /// </summary>
        public string nameExam { get; private set; }
        /// <summary>
        /// Результат сдачи экзамена
        /// </summary>
        public int result { get; set; }

        public Exam(string nameExam)
        {
            this.nameExam = nameExam;
            this.result = 0;
        }
    }
}
