using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        TypeFile typeFile;
        ContextDB contextDB = new ContextDB();
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void showCurStudent(Student student)
        {
            textBox1.Text = student.familyName;
            textBox2.Text = student.name;
            textBox3.Text = student.age.ToString();
            textBox4.Text = student.group.name;
            textBox5.Text = student.group.kurs.ToString();
        }

        public void showStudents()
        {
            Student[] students = contextDB.GetStudents();
            listBox1.Items.Clear();

            foreach (var stdnt in students)
            {
                listBox1.Items.Add(stdnt);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student stdnt =(Student)listBox1.SelectedItem;
            contextDB.SetCurStudent(stdnt);
            showCurStudent(stdnt);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.ShowDialog();
                contextDB.Save(sf.FileName, TypeFile.txt);
            }
            if (radioButton2.Checked)
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.ShowDialog();
                contextDB.Save(sf.FileName, TypeFile.xml);
            }
            if (radioButton3.Checked)
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.ShowDialog();
                contextDB.Save(sf.FileName, TypeFile.json);
            }
        }

        private void loadDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                OpenFileDialog of = new OpenFileDialog();
                of.ShowDialog();
                contextDB.Load(of.FileName, TypeFile.txt);
                showStudents();
                showCurStudent(contextDB.GetCurStudent());
            }
            if (radioButton2.Checked)
            {
                OpenFileDialog of = new OpenFileDialog();
                of.ShowDialog();
                contextDB.Load(of.FileName, TypeFile.xml);
                showStudents();
                showCurStudent(contextDB.GetCurStudent());
            }
            if (radioButton3.Checked)
            {
                OpenFileDialog of = new OpenFileDialog();
                of.ShowDialog();
                contextDB.Load(of.FileName, TypeFile.json);
                showStudents();
                showCurStudent(contextDB.GetCurStudent());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contextDB.Prev();
            showCurStudent(contextDB.GetCurStudent());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            contextDB.Add(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), textBox4.Text, Convert.ToInt32(textBox5.Text));
            showStudents();
            showCurStudent(contextDB.GetCurStudent());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Выберите студента в основном окне программы!");
                return;
            }
            Student find = (Student)listBox1.SelectedItem;
            Student replace = new Student(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), textBox4.Text, Convert.ToInt32(textBox5.Text));
            contextDB.Edit(find, replace);
            showStudents();
            showCurStudent(contextDB.GetCurStudent());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            contextDB.Remove();
            listBox1.Items.Clear();
            showStudents();
            showCurStudent(contextDB.GetCurStudent());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            contextDB.Next();
            showCurStudent(contextDB.GetCurStudent());
        }
    }
}
