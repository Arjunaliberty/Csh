using ClassLibrary1;
using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Controls;


namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ContextDB contextDB = new ContextDB();

        public MainWindow()
        {
            InitializeComponent();
        }

        public void ShowStudents()
        {
            Student[] students = contextDB.GetStudents();
            listBox.Items.Clear();

            foreach (Student stud in students)
            {
                listBox.Items.Add(stud);
            }
        } 

        public void ShowCurrentStudent()
        {
            Student stud = contextDB.GetCurStudent();

            textBox1.Text = stud.familyName;
            textBox2.Text = stud.name;
            textBox3.Text = stud.age.ToString();
            textBox4.Text = stud.group.name;
            textBox5.Text = stud.group.kurs.ToString();
        }

        private void LoadDB_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();

            of.ShowDialog();
            contextDB.LoadTXT(of.FileName);
            listBox.Items.Clear();
            ShowStudents();
            ShowCurrentStudent();
        }

        private void SaveDB_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();

            sf.ShowDialog();
            contextDB.SaveTXT(sf.FileName);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Student stud = (Student)listBox.SelectedItem;
            contextDB.SetCurStudent(stud);
            ShowCurrentStudent();
        }

        private void button_prev_Click(object sender, RoutedEventArgs e)
        {
            contextDB.Prev();
            ShowCurrentStudent();
        }

        private void button_add_Click(object sender, RoutedEventArgs e)
        {
            contextDB.Add(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), textBox4.Text, Convert.ToInt32(textBox5.Text));
            ShowStudents();
            ShowCurrentStudent();
        }

        private void button_edit_Click(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите студента в основном окне программы!");
                return;
            }
            Student find = (Student)listBox.SelectedItem;
            Student replace = new Student(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), textBox4.Text, Convert.ToInt32(textBox5.Text));
            contextDB.Edit(find, replace);
            ShowStudents();
            ShowCurrentStudent();
        }

        private void button_delete_Click(object sender, RoutedEventArgs e)
        {
            contextDB.Remove();
            ShowStudents();
            ShowCurrentStudent();
        }

        private void button_nex_Click(object sender, RoutedEventArgs e)
        {
            contextDB.Next();
            ShowCurrentStudent();
        }
    }
}
