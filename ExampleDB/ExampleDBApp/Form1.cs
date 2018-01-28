using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleDBApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void examsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.examsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.exapleDB);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "exapleDB.Subjects". При необходимости она может быть перемещена или удалена.
            this.subjectsTableAdapter.Fill(this.exapleDB.Subjects);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "exapleDB.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.exapleDB.Students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "exapleDB.Exams". При необходимости она может быть перемещена или удалена.
            this.examsTableAdapter.Fill(this.exapleDB.Exams);

        }

        /// <summary>
        /// Вызов формы модального окна с вормой для талицы Students
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using(StudentsForm studentsForm = new StudentsForm())
            {
                studentsForm.ShowDialog();
            }
        }

        /// <summary>
        /// Вызов формы модального окна с вормой для талицы Subject
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            using (SubjectsForm subjectsForm = new SubjectsForm())
            {
                subjectsForm.ShowDialog();
            }
        }
    }
}
