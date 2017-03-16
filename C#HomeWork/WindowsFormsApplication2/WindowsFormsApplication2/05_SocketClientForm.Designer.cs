namespace WindowsFormsApplication2
{
    partial class _05_SocketClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBoxClient = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkBoxPrev = new System.Windows.Forms.CheckBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxClient
            // 
            this.richTextBoxClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxClient.Location = new System.Drawing.Point(165, 12);
            this.richTextBoxClient.Name = "richTextBoxClient";
            this.richTextBoxClient.Size = new System.Drawing.Size(440, 495);
            this.richTextBoxClient.TabIndex = 0;
            this.richTextBoxClient.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 532);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(440, 22);
            this.textBox1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(147, 424);
            this.listBox1.TabIndex = 2;
            // 
            // checkBoxPrev
            // 
            this.checkBoxPrev.AutoSize = true;
            this.checkBoxPrev.Location = new System.Drawing.Point(165, 570);
            this.checkBoxPrev.Name = "checkBoxPrev";
            this.checkBoxPrev.Size = new System.Drawing.Size(60, 16);
            this.checkBoxPrev.TabIndex = 3;
            this.checkBoxPrev.Text = "悄悄话";
            this.checkBoxPrev.UseVisualStyleBackColor = true;
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonConnect.Location = new System.Drawing.Point(12, 455);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "连接服务器";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.BackColor = System.Drawing.Color.LightGray;
            this.buttonDisconnect.Enabled = false;
            this.buttonDisconnect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDisconnect.Location = new System.Drawing.Point(12, 484);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonDisconnect.TabIndex = 4;
            this.buttonDisconnect.Text = "断开连接";
            this.buttonDisconnect.UseVisualStyleBackColor = false;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(530, 566);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 4;
            this.buttonSend.Text = "发送";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 513);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // _05_SocketClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 611);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.checkBoxPrev);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBoxClient);
            this.Name = "_05_SocketClientForm";
            this.Text = "SocketClient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._05_SocketClientForm_FormClosing);
            this.Load += new System.EventHandler(this._05_SocketClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxClient;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox checkBoxPrev;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button button4;
    }
}