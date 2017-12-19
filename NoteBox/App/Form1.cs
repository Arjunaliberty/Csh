﻿using Library;
using System;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        private String fileName = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void File_Load(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            fileName = openFileDialog.FileName;
            FileWrapper.SetFileName(fileName);
            textBox1.Text = FileWrapper.OpenFile();
        }

        private void File_Save(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = fileName;
            saveFileDialog.ShowDialog();
            FileWrapper.SetFileName(saveFileDialog.FileName);
            FileWrapper.SaveFile(textBox1.Text);
        }

        private void FileInfo_Load(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            fileName = openFileDialog.FileName;
            FileInfoWrapper fiw = new FileInfoWrapper(fileName);
            textBox1.Text = fiw.OpenFile();
        }

        private void FileInfo_Save(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = fileName;
            FileInfoWrapper fiw = new FileInfoWrapper(fileName);
            fiw.SaveFile(textBox1.Text);
        }

        private void FileStrea_Load(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            fileName = ofd.FileName;
            FileStreamWrapper.fileName = fileName;
            textBox1.Text = FileStreamWrapper.OpenFile();
        }

        private void FileStream_Save(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = fileName;
            sfd.ShowDialog();
            FileStreamWrapper.SaveFile(textBox1.Text);
        }
    }
}
