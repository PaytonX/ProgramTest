namespace WindowsFormsApplication2
{
    partial class StringForm2
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
            this.components = new System.ComponentModel.Container();
            this.StrcomboBox1 = new System.Windows.Forms.ComboBox();
            this.StrcomboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StrtextBoxinput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StrtextBox1 = new System.Windows.Forms.TextBox();
            this.Strlabel1 = new System.Windows.Forms.Label();
            this.StrtextBox2 = new System.Windows.Forms.TextBox();
            this.Strlabel2 = new System.Windows.Forms.Label();
            this.StrtextBox3 = new System.Windows.Forms.TextBox();
            this.Strlabel3 = new System.Windows.Forms.Label();
            this.StrtextBoxoutput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // StrcomboBox1
            // 
            this.StrcomboBox1.FormattingEnabled = true;
            this.StrcomboBox1.Items.AddRange(new object[] {
            "A. 截取：Mid()、Right()、Left()",
            "B. 合併：&、+",
            "C. 搜尋：Instr()、InstrRev()",
            "D. 取代：Replace()",
            "E. 轉換：Val()、Hex()、Asc()、UCase()、Lcase()",
            "F. 比對：StrComp()",
            "G. 去空白：Ltrim()、Rtrim()、Trim()",
            "H. 格式化：Format()"});
            this.StrcomboBox1.Location = new System.Drawing.Point(37, 37);
            this.StrcomboBox1.Name = "StrcomboBox1";
            this.StrcomboBox1.Size = new System.Drawing.Size(198, 20);
            this.StrcomboBox1.TabIndex = 0;
            this.StrcomboBox1.TextChanged += new System.EventHandler(this.StrcomboBox1_TextChanged);
            // 
            // StrcomboBox2
            // 
            this.StrcomboBox2.FormattingEnabled = true;
            this.StrcomboBox2.Location = new System.Drawing.Point(37, 87);
            this.StrcomboBox2.Name = "StrcomboBox2";
            this.StrcomboBox2.Size = new System.Drawing.Size(198, 20);
            this.StrcomboBox2.TabIndex = 1;
            this.StrcomboBox2.TextChanged += new System.EventHandler(this.StrcomboBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "功能类型选择：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "具体功能选择：";
            // 
            // StrtextBoxinput
            // 
            this.StrtextBoxinput.Location = new System.Drawing.Point(311, 36);
            this.StrtextBoxinput.Name = "StrtextBoxinput";
            this.StrtextBoxinput.Size = new System.Drawing.Size(320, 21);
            this.StrtextBoxinput.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "输入待处理的字符串";
            // 
            // StrtextBox1
            // 
            this.StrtextBox1.Location = new System.Drawing.Point(39, 143);
            this.StrtextBox1.Name = "StrtextBox1";
            this.StrtextBox1.Size = new System.Drawing.Size(195, 21);
            this.StrtextBox1.TabIndex = 6;
            // 
            // Strlabel1
            // 
            this.Strlabel1.AutoSize = true;
            this.Strlabel1.Location = new System.Drawing.Point(37, 128);
            this.Strlabel1.Name = "Strlabel1";
            this.Strlabel1.Size = new System.Drawing.Size(47, 12);
            this.Strlabel1.TabIndex = 7;
            this.Strlabel1.Text = "参数1：";
            // 
            // StrtextBox2
            // 
            this.StrtextBox2.Location = new System.Drawing.Point(37, 205);
            this.StrtextBox2.Name = "StrtextBox2";
            this.StrtextBox2.Size = new System.Drawing.Size(197, 21);
            this.StrtextBox2.TabIndex = 8;
            // 
            // Strlabel2
            // 
            this.Strlabel2.AutoSize = true;
            this.Strlabel2.Location = new System.Drawing.Point(37, 190);
            this.Strlabel2.Name = "Strlabel2";
            this.Strlabel2.Size = new System.Drawing.Size(47, 12);
            this.Strlabel2.TabIndex = 9;
            this.Strlabel2.Text = "参数2：";
            // 
            // StrtextBox3
            // 
            this.StrtextBox3.Location = new System.Drawing.Point(39, 272);
            this.StrtextBox3.Name = "StrtextBox3";
            this.StrtextBox3.Size = new System.Drawing.Size(194, 21);
            this.StrtextBox3.TabIndex = 10;
            // 
            // Strlabel3
            // 
            this.Strlabel3.AutoSize = true;
            this.Strlabel3.Location = new System.Drawing.Point(37, 257);
            this.Strlabel3.Name = "Strlabel3";
            this.Strlabel3.Size = new System.Drawing.Size(47, 12);
            this.Strlabel3.TabIndex = 11;
            this.Strlabel3.Text = "参数3：";
            // 
            // StrtextBoxoutput
            // 
            this.StrtextBoxoutput.Location = new System.Drawing.Point(310, 97);
            this.StrtextBoxoutput.Multiline = true;
            this.StrtextBoxoutput.Name = "StrtextBoxoutput";
            this.StrtextBoxoutput.Size = new System.Drawing.Size(319, 147);
            this.StrtextBoxoutput.TabIndex = 12;
            this.StrtextBoxoutput.MouseEnter += new System.EventHandler(this.StrtextBoxoutput_MouseEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "处理后的结果：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 21);
            this.button1.TabIndex = 14;
            this.button1.Text = "开始处理";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StringForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 316);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StrtextBoxoutput);
            this.Controls.Add(this.Strlabel3);
            this.Controls.Add(this.StrtextBox3);
            this.Controls.Add(this.Strlabel2);
            this.Controls.Add(this.StrtextBox2);
            this.Controls.Add(this.Strlabel1);
            this.Controls.Add(this.StrtextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StrtextBoxinput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StrcomboBox2);
            this.Controls.Add(this.StrcomboBox1);
            this.Name = "StringForm2";
            this.Text = "字符串练习";
            this.Load += new System.EventHandler(this.StringForm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox StrcomboBox1;
        private System.Windows.Forms.ComboBox StrcomboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StrtextBoxinput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StrtextBox1;
        private System.Windows.Forms.Label Strlabel1;
        private System.Windows.Forms.TextBox StrtextBox2;
        private System.Windows.Forms.Label Strlabel2;
        private System.Windows.Forms.TextBox StrtextBox3;
        private System.Windows.Forms.Label Strlabel3;
        private System.Windows.Forms.TextBox StrtextBoxoutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}