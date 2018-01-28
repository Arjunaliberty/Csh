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
    public partial class StudentsForm : Form
    {
        public StudentsForm()
        {
            InitializeComponent();
        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.exapleDB);

        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "exapleDB.Groups". При необходимости она может быть перемещена или удалена.
            this.groupsTableAdapter.Fill(this.exapleDB.Groups);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "exapleDB.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.exapleDB.Students);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using(GroupsForm groupsForm = new GroupsForm())
            {
                groupsForm.ShowDialog();
            }
        }
    }
}
