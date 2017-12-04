using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libs;

namespace Chat
{
    public partial class Form1 : Form
    {
        SocketWrap socketWrap;
//        List<string> msgChat = new List<string>();


        public Form1()
        {
            InitializeComponent();

            socketWrap = new SocketWrap();

        }


        private void checkedChanged()
        {
            if(radioClient.Checked)
            {
                labelIP.Visible = true;
                textIP.Visible = true;
                textName.Text = "Client";
                labelPort.Visible = true;
                textPort.Visible = true;
            }
            else
            {
                labelIP.Visible = false;
                textIP.Visible = false;
                labelPort.Visible = false;
                textPort.Visible = false;
                textName.Text = "Server";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            checkedChanged();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            checkedChanged();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            socketWrap.closeSockets();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {

            if (radioClient.Checked)
            {
                socketWrap.CreateClientSocket(textIP.Text, textPort.Text);
            }
            else
            {
                socketWrap.CreateServerSocket(textIP.Text, textPort.Text);
            }
            panel1.Visible = false;
            panel2.Visible = true;
            timer1.Start();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {

            string msg = labelName.Text + " <"+ DateTime.Now.ToShortTimeString() + ">: " + textMsg.Text;

            textMsgs.AppendText(msg + Environment.NewLine);

            socketWrap.send2client(msg);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string msg = null;
            msg = socketWrap.recvFromClient();

            if(msg != null)
            {
                textMsgs.AppendText(msg + Environment.NewLine);
            }

        }
    }
}
