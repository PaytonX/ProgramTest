namespace WindowsFormsApplication2
{
    partial class FileForm3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CreatFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileFunctionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileCopyItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileAppendItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMoveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileDeleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空缓存区ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.sorcetextBox1 = new System.Windows.Forms.TextBox();
            this.targettextBox1 = new System.Windows.Forms.TextBox();
            this.sourcebutton1 = new System.Windows.Forms.Button();
            this.targetbutton2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.搜索ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreatFileMenuItem,
            this.OpenFileMenuItem,
            this.SaveFileMenuItem,
            this.FileFunctionMenuItem,
            this.清空缓存区ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(457, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CreatFileMenuItem
            // 
            this.CreatFileMenuItem.Name = "CreatFileMenuItem";
            this.CreatFileMenuItem.Size = new System.Drawing.Size(44, 21);
            this.CreatFileMenuItem.Text = "新建";
            this.CreatFileMenuItem.Click += new System.EventHandler(this.文件ToolStripMenuItem_Click);
            // 
            // OpenFileMenuItem
            // 
            this.OpenFileMenuItem.Name = "OpenFileMenuItem";
            this.OpenFileMenuItem.Size = new System.Drawing.Size(44, 21);
            this.OpenFileMenuItem.Text = "打开";
            this.OpenFileMenuItem.Click += new System.EventHandler(this.OpenFileMenuItem_Click);
            // 
            // SaveFileMenuItem
            // 
            this.SaveFileMenuItem.Name = "SaveFileMenuItem";
            this.SaveFileMenuItem.Size = new System.Drawing.Size(44, 21);
            this.SaveFileMenuItem.Text = "保存";
            this.SaveFileMenuItem.Click += new System.EventHandler(this.SaveFileMenuItem_Click);
            // 
            // FileFunctionMenuItem
            // 
            this.FileFunctionMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileCopyItem,
            this.FileAppendItem,
            this.FileMoveItem,
            this.FileDeleteItem,
            this.搜索ToolStripMenuItem});
            this.FileFunctionMenuItem.Name = "FileFunctionMenuItem";
            this.FileFunctionMenuItem.Size = new System.Drawing.Size(44, 21);
            this.FileFunctionMenuItem.Text = "功能";
            // 
            // FileCopyItem
            // 
            this.FileCopyItem.Name = "FileCopyItem";
            this.FileCopyItem.Size = new System.Drawing.Size(100, 22);
            this.FileCopyItem.Text = "复制";
            this.FileCopyItem.Click += new System.EventHandler(this.FileCopyItem_Click);
            // 
            // FileAppendItem
            // 
            this.FileAppendItem.Name = "FileAppendItem";
            this.FileAppendItem.Size = new System.Drawing.Size(100, 22);
            this.FileAppendItem.Text = "添加";
            this.FileAppendItem.Click += new System.EventHandler(this.FileAppendItem_Click);
            // 
            // FileMoveItem
            // 
            this.FileMoveItem.Name = "FileMoveItem";
            this.FileMoveItem.Size = new System.Drawing.Size(100, 22);
            this.FileMoveItem.Text = "移动";
            this.FileMoveItem.Click += new System.EventHandler(this.FileMoveItem_Click);
            // 
            // FileDeleteItem
            // 
            this.FileDeleteItem.Name = "FileDeleteItem";
            this.FileDeleteItem.Size = new System.Drawing.Size(100, 22);
            this.FileDeleteItem.Text = "删除";
            this.FileDeleteItem.Click += new System.EventHandler(this.FileDeleteItem_Click);
            // 
            // 清空缓存区ToolStripMenuItem
            // 
            this.清空缓存区ToolStripMenuItem.Name = "清空缓存区ToolStripMenuItem";
            this.清空缓存区ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.清空缓存区ToolStripMenuItem.Text = "清空缓存区";
            this.清空缓存区ToolStripMenuItem.Click += new System.EventHandler(this.清空缓存区ToolStripMenuItem_Click);
            // 
            // fileTextBox
            // 
            this.fileTextBox.Location = new System.Drawing.Point(12, 28);
            this.fileTextBox.Multiline = true;
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(433, 134);
            this.fileTextBox.TabIndex = 2;
            // 
            // sorcetextBox1
            // 
            this.sorcetextBox1.Location = new System.Drawing.Point(14, 383);
            this.sorcetextBox1.Name = "sorcetextBox1";
            this.sorcetextBox1.ReadOnly = true;
            this.sorcetextBox1.Size = new System.Drawing.Size(391, 22);
            this.sorcetextBox1.TabIndex = 3;
            // 
            // targettextBox1
            // 
            this.targettextBox1.Location = new System.Drawing.Point(12, 425);
            this.targettextBox1.Name = "targettextBox1";
            this.targettextBox1.ReadOnly = true;
            this.targettextBox1.Size = new System.Drawing.Size(391, 22);
            this.targettextBox1.TabIndex = 3;
            // 
            // sourcebutton1
            // 
            this.sourcebutton1.Location = new System.Drawing.Point(409, 381);
            this.sourcebutton1.Name = "sourcebutton1";
            this.sourcebutton1.Size = new System.Drawing.Size(36, 21);
            this.sourcebutton1.TabIndex = 4;
            this.sourcebutton1.Text = "...";
            this.sourcebutton1.UseVisualStyleBackColor = true;
            this.sourcebutton1.Click += new System.EventHandler(this.sourcebutton1_Click);
            // 
            // targetbutton2
            // 
            this.targetbutton2.Location = new System.Drawing.Point(409, 424);
            this.targetbutton2.Name = "targetbutton2";
            this.targetbutton2.Size = new System.Drawing.Size(36, 21);
            this.targetbutton2.TabIndex = 4;
            this.targetbutton2.Text = "...";
            this.targetbutton2.UseVisualStyleBackColor = true;
            this.targetbutton2.Click += new System.EventHandler(this.targetbutton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Source File:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Target Directory:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(14, 192);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(431, 172);
            this.listBox1.TabIndex = 6;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 177);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(33, 12);
            this.labelResult.TabIndex = 7;
            this.labelResult.Text = "label3";
            // 
            // 搜索ToolStripMenuItem
            // 
            this.搜索ToolStripMenuItem.Name = "搜索ToolStripMenuItem";
            this.搜索ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.搜索ToolStripMenuItem.Text = "搜索";
            this.搜索ToolStripMenuItem.Click += new System.EventHandler(this.搜索ToolStripMenuItem_Click);
            // 
            // FileForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 458);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.targetbutton2);
            this.Controls.Add(this.sourcebutton1);
            this.Controls.Add(this.targettextBox1);
            this.Controls.Add(this.sorcetextBox1);
            this.Controls.Add(this.fileTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FileForm3";
            this.Text = "档案IO存取";
            this.Load += new System.EventHandler(this.FileForm3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CreatFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileFunctionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileCopyItem;
        private System.Windows.Forms.ToolStripMenuItem FileAppendItem;
        private System.Windows.Forms.ToolStripMenuItem FileMoveItem;
        private System.Windows.Forms.ToolStripMenuItem FileDeleteItem;
        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.ToolStripMenuItem 清空缓存区ToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox sorcetextBox1;
        private System.Windows.Forms.TextBox targettextBox1;
        private System.Windows.Forms.Button sourcebutton1;
        private System.Windows.Forms.Button targetbutton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.ToolStripMenuItem 搜索ToolStripMenuItem;
    }
}