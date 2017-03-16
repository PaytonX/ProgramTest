namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxyuanxi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxzhuanye = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.姓名输入提示 = new System.Windows.Forms.ToolTip(this.components);
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.档案IOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字符串处理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.socketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.socketServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sockerClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.MouseEnter += new System.EventHandler(this.textBox1_MouseEnter);
            this.textBox1.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "性别：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(50, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 41);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(98, 17);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 16);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "中性";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(57, 17);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(35, 16);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "女";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 17);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(35, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "男";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "院系：";
            // 
            // comboBoxyuanxi
            // 
            this.comboBoxyuanxi.FormattingEnabled = true;
            this.comboBoxyuanxi.Items.AddRange(new object[] {
            "建筑与环境工程系 ",
            "汽车工程系",
            "管理系",
            "机械系",
            "电子电气工程系",
            "计算机科学系"});
            this.comboBoxyuanxi.Location = new System.Drawing.Point(48, 20);
            this.comboBoxyuanxi.Name = "comboBoxyuanxi";
            this.comboBoxyuanxi.Size = new System.Drawing.Size(141, 20);
            this.comboBoxyuanxi.TabIndex = 5;
            this.comboBoxyuanxi.SelectedIndexChanged += new System.EventHandler(this.comboBoxyuanxi_SelectedIndexChanged);
            this.comboBoxyuanxi.TextChanged += new System.EventHandler(this.comboBoxyuanxi_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "专业：";
            // 
            // listBoxzhuanye
            // 
            this.listBoxzhuanye.FormattingEnabled = true;
            this.listBoxzhuanye.ItemHeight = 12;
            this.listBoxzhuanye.Location = new System.Drawing.Point(48, 71);
            this.listBoxzhuanye.Name = "listBoxzhuanye";
            this.listBoxzhuanye.Size = new System.Drawing.Size(141, 88);
            this.listBoxzhuanye.TabIndex = 8;
            this.listBoxzhuanye.SelectedIndexChanged += new System.EventHandler(this.listBoxzhuanye_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxyuanxi);
            this.groupBox2.Controls.Add(this.listBoxzhuanye);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(14, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 173);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "专业信息";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePicker2);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Location = new System.Drawing.Point(14, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(208, 149);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "基本信息";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(81, 112);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(108, 22);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(81, 87);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(108, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "毕业时间：";
            this.label6.Click += new System.EventHandler(this.label5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "出生时间：";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(178, 383);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 27);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkedListBox1);
            this.groupBox4.Location = new System.Drawing.Point(241, 40);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox4.Size = new System.Drawing.Size(179, 140);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "爱好";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "羽毛球",
            "篮球",
            "足球",
            "跳舞",
            "唱歌",
            "游泳",
            "书法",
            "游戏",
            "工作",
            "尾行",
            "女",
            "男"});
            this.checkedListBox1.Location = new System.Drawing.Point(6, 20);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(167, 106);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            this.checkedListBox1.SelectedValueChanged += new System.EventHandler(this.checkedListBox1_SelectedValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmenu,
            this.tlsMenu2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(450, 25);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // tsmenu
            // 
            this.tsmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.档案IOToolStripMenuItem,
            this.字符串处理ToolStripMenuItem,
            this.退出ToolStripMenuItem,
            this.socketToolStripMenuItem});
            this.tsmenu.Name = "tsmenu";
            this.tsmenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.tsmenu.Size = new System.Drawing.Size(44, 21);
            this.tsmenu.Text = "系统";
            this.tsmenu.Click += new System.EventHandler(this.tsmenu_Click);
            // 
            // 档案IOToolStripMenuItem
            // 
            this.档案IOToolStripMenuItem.Name = "档案IOToolStripMenuItem";
            this.档案IOToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.档案IOToolStripMenuItem.Text = "档案IO存取";
            this.档案IOToolStripMenuItem.Click += new System.EventHandler(this.档案IOToolStripMenuItem_Click);
            // 
            // 字符串处理ToolStripMenuItem
            // 
            this.字符串处理ToolStripMenuItem.Name = "字符串处理ToolStripMenuItem";
            this.字符串处理ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.字符串处理ToolStripMenuItem.Text = "字符串处理";
            this.字符串处理ToolStripMenuItem.Click += new System.EventHandler(this.字符串处理ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // socketToolStripMenuItem
            // 
            this.socketToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.socketServerToolStripMenuItem,
            this.sockerClientToolStripMenuItem});
            this.socketToolStripMenuItem.Name = "socketToolStripMenuItem";
            this.socketToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.socketToolStripMenuItem.Text = "Socket";
            // 
            // socketServerToolStripMenuItem
            // 
            this.socketServerToolStripMenuItem.Name = "socketServerToolStripMenuItem";
            this.socketServerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.socketServerToolStripMenuItem.Text = "SocketServer";
            this.socketServerToolStripMenuItem.Click += new System.EventHandler(this.socketServerToolStripMenuItem_Click);
            // 
            // sockerClientToolStripMenuItem
            // 
            this.sockerClientToolStripMenuItem.Name = "sockerClientToolStripMenuItem";
            this.sockerClientToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sockerClientToolStripMenuItem.Text = "SocketClient";
            this.sockerClientToolStripMenuItem.Click += new System.EventHandler(this.sockerClientToolStripMenuItem_Click);
            // 
            // tlsMenu2
            // 
            this.tlsMenu2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.tlsMenu2.Name = "tlsMenu2";
            this.tlsMenu2.Size = new System.Drawing.Size(44, 21);
            this.tlsMenu2.Text = "帮助";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem1.Text = "版本信息";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem2.Text = "关于";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 20);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 147);
            this.textBox2.TabIndex = 14;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Location = new System.Drawing.Point(232, 204);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(187, 172);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "结果";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 422);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "信息录入";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxyuanxi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxzhuanye;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip 姓名输入提示;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmenu;
        private System.Windows.Forms.ToolStripMenuItem tlsMenu2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字符串处理ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem 档案IOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem socketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem socketServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sockerClientToolStripMenuItem;
    }
}

