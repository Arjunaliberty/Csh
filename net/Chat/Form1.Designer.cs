namespace Chat
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelMsg = new System.Windows.Forms.Label();
            this.textMsg = new System.Windows.Forms.TextBox();
            this.textMsgs = new System.Windows.Forms.TextBox();
            this.radioClient = new System.Windows.Forms.RadioButton();
            this.radioServer = new System.Windows.Forms.RadioButton();
            this.labelIP = new System.Windows.Forms.Label();
            this.textIP = new System.Windows.Forms.TextBox();
            this.textPort = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonConnect);
            this.panel1.Controls.Add(this.textName);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.textPort);
            this.panel1.Controls.Add(this.labelPort);
            this.panel1.Controls.Add(this.textIP);
            this.panel1.Controls.Add(this.labelIP);
            this.panel1.Controls.Add(this.radioServer);
            this.panel1.Controls.Add(this.radioClient);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 183);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonSend);
            this.panel2.Controls.Add(this.labelMsg);
            this.panel2.Controls.Add(this.textMsg);
            this.panel2.Controls.Add(this.textMsgs);
            this.panel2.Location = new System.Drawing.Point(12, 201);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 264);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(460, 231);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 8;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // labelMsg
            // 
            this.labelMsg.AutoSize = true;
            this.labelMsg.Location = new System.Drawing.Point(3, 236);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(50, 13);
            this.labelMsg.TabIndex = 7;
            this.labelMsg.Text = "Message";
            // 
            // textMsg
            // 
            this.textMsg.Location = new System.Drawing.Point(54, 233);
            this.textMsg.Name = "textMsg";
            this.textMsg.Size = new System.Drawing.Size(400, 20);
            this.textMsg.TabIndex = 6;
            // 
            // textMsgs
            // 
            this.textMsgs.Location = new System.Drawing.Point(0, 3);
            this.textMsgs.Multiline = true;
            this.textMsgs.Name = "textMsgs";
            this.textMsgs.Size = new System.Drawing.Size(535, 224);
            this.textMsgs.TabIndex = 5;
            // 
            // radioClient
            // 
            this.radioClient.AutoSize = true;
            this.radioClient.Checked = true;
            this.radioClient.Location = new System.Drawing.Point(6, 3);
            this.radioClient.Name = "radioClient";
            this.radioClient.Size = new System.Drawing.Size(51, 17);
            this.radioClient.TabIndex = 1;
            this.radioClient.TabStop = true;
            this.radioClient.Text = "Client";
            this.radioClient.UseVisualStyleBackColor = true;
            this.radioClient.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioServer
            // 
            this.radioServer.AutoSize = true;
            this.radioServer.Location = new System.Drawing.Point(63, 3);
            this.radioServer.Name = "radioServer";
            this.radioServer.Size = new System.Drawing.Size(56, 17);
            this.radioServer.TabIndex = 2;
            this.radioServer.Text = "Server";
            this.radioServer.UseVisualStyleBackColor = true;
            this.radioServer.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(3, 29);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(15, 13);
            this.labelIP.TabIndex = 3;
            this.labelIP.Text = "ip";
            // 
            // textIP
            // 
            this.textIP.Location = new System.Drawing.Point(24, 26);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(100, 20);
            this.textIP.TabIndex = 4;
            this.textIP.Text = "127.0.0.1";
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(163, 26);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(37, 20);
            this.textPort.TabIndex = 6;
            this.textPort.Text = "8080";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(132, 29);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(25, 13);
            this.labelPort.TabIndex = 5;
            this.labelPort.Text = "port";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(44, 55);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(80, 20);
            this.textName.TabIndex = 8;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 58);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(135, 53);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(65, 23);
            this.buttonConnect.TabIndex = 9;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 475);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelMsg;
        private System.Windows.Forms.TextBox textMsg;
        private System.Windows.Forms.TextBox textMsgs;
        private System.Windows.Forms.RadioButton radioServer;
        private System.Windows.Forms.RadioButton radioClient;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox textIP;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Timer timer1;
    }
}

