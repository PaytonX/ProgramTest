namespace SQLRuningTool
{
    partial class SQLForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbox_Path = new System.Windows.Forms.TextBox();
            this.btn_Open = new System.Windows.Forms.Button();
            this.cbox_VersionSelect = new System.Windows.Forms.ComboBox();
            this.cbox_LineTypeSelect = new System.Windows.Forms.ComboBox();
            this.btn_Run = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LineNoSelect = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Link = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbShop = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbox_Path
            // 
            this.tbox_Path.Location = new System.Drawing.Point(58, 20);
            this.tbox_Path.Name = "tbox_Path";
            this.tbox_Path.Size = new System.Drawing.Size(281, 21);
            this.tbox_Path.TabIndex = 0;
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(345, 20);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(48, 21);
            this.btn_Open.TabIndex = 1;
            this.btn_Open.Text = "Open";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // cbox_VersionSelect
            // 
            this.cbox_VersionSelect.FormattingEnabled = true;
            this.cbox_VersionSelect.Location = new System.Drawing.Point(94, 72);
            this.cbox_VersionSelect.Name = "cbox_VersionSelect";
            this.cbox_VersionSelect.Size = new System.Drawing.Size(69, 20);
            this.cbox_VersionSelect.TabIndex = 2;
            // 
            // cbox_LineTypeSelect
            // 
            this.cbox_LineTypeSelect.FormattingEnabled = true;
            this.cbox_LineTypeSelect.Location = new System.Drawing.Point(234, 46);
            this.cbox_LineTypeSelect.Name = "cbox_LineTypeSelect";
            this.cbox_LineTypeSelect.Size = new System.Drawing.Size(105, 20);
            this.cbox_LineTypeSelect.TabIndex = 3;
            this.cbox_LineTypeSelect.SelectedValueChanged += new System.EventHandler(this.cbox_LineTypeSelect_SelectedValueChanged);
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(345, 72);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(48, 21);
            this.btn_Run.TabIndex = 4;
            this.btn_Run.Text = "Run";
            this.btn_Run.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F);
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Path：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "SQL Version:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "LineType:";
            // 
            // LineNoSelect
            // 
            this.LineNoSelect.FormattingEnabled = true;
            this.LineNoSelect.Location = new System.Drawing.Point(234, 72);
            this.LineNoSelect.Name = "LineNoSelect";
            this.LineNoSelect.Size = new System.Drawing.Size(105, 20);
            this.LineNoSelect.TabIndex = 3;
            this.LineNoSelect.SelectedValueChanged += new System.EventHandler(this.LineNoSelect_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "LineNo:";
            // 
            // btn_Link
            // 
            this.btn_Link.Location = new System.Drawing.Point(345, 45);
            this.btn_Link.Name = "btn_Link";
            this.btn_Link.Size = new System.Drawing.Size(48, 22);
            this.btn_Link.TabIndex = 9;
            this.btn_Link.Text = "Link";
            this.btn_Link.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Shop:";
            // 
            // cmbShop
            // 
            this.cmbShop.FormattingEnabled = true;
            this.cmbShop.Location = new System.Drawing.Point(58, 45);
            this.cmbShop.Name = "cmbShop";
            this.cmbShop.Size = new System.Drawing.Size(105, 20);
            this.cmbShop.TabIndex = 3;
            this.cmbShop.SelectedValueChanged += new System.EventHandler(this.cmbShop_SelectedValueChanged);
            // 
            // SQLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 110);
            this.Controls.Add(this.btn_Link);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Run);
            this.Controls.Add(this.LineNoSelect);
            this.Controls.Add(this.cmbShop);
            this.Controls.Add(this.cbox_LineTypeSelect);
            this.Controls.Add(this.cbox_VersionSelect);
            this.Controls.Add(this.btn_Open);
            this.Controls.Add(this.tbox_Path);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SQLForm";
            this.Text = "SQL Runing Tools";
            this.Load += new System.EventHandler(this.SQLForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_Path;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.ComboBox cbox_VersionSelect;
        private System.Windows.Forms.ComboBox cbox_LineTypeSelect;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox LineNoSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Link;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbShop;
    }
}

