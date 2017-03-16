using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace WindowsFormsApplication2
{
    public partial class FileForm3 : Form
    {
        public FileForm3()
        {
            InitializeComponent();

        }

        #region 新建文件
        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog creatFile = new SaveFileDialog();
            creatFile.Filter = "txt files(*.txt)|*.txt|xml files(*.xml)|*.xml|doc files(*.doc)|*.doc|All files(*.*)|*.*";//设置文件新建格式
            creatFile.FilterIndex = 1;//设置初始新建的文件类型
            creatFile.RestoreDirectory = true;//保存上次打开的路径
            creatFile.Title = "新建";
            if (creatFile.ShowDialog() == DialogResult.OK)//当点下保存按钮时执行内部程序
            {
                string localFilePath = creatFile.FileName.ToString();
                //Console.WriteLine(localFilePath);
                FileStream fs = new FileStream(localFilePath, FileMode.Create, FileAccess.ReadWrite);
                fs.Dispose();
                log.LogRecord("新建文件："+creatFile.FileName.ToString());
                
                
            }
            
        }
        #endregion

        #region 打开文件
        private void OpenFileMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "txt files(*.txt)|*.txt|xml files(*.xml)|*.xml|doc files(*.doc)|*.doc|All files(*.*)|*.*";//设置打开文件的格式
            openFile.RestoreDirectory = true;//保存上次打开的路径
            openFile.Title = "打开";
            if (openFile.ShowDialog()==DialogResult.OK)//当按下打开时执行内部程序
            {
                string localFilePath = openFile.FileName.ToString();
                FileStream fs = new FileStream(localFilePath, FileMode.Open, FileAccess.ReadWrite);
                StreamReader sr = new StreamReader(fs);
                fileTextBox.Clear();
                fileTextBox.Text = sr.ReadToEnd();
                sr.Dispose();
                fs.Dispose();
                log.LogRecord("打开文件：" +openFile.FileName.ToString());
            }
            
        }
        #endregion

        #region 清空缓存
        private void 清空缓存区ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileTextBox.Clear();//清空缓存区
            //Console.WriteLine(System.Windows.Forms.Application.StartupPath.ToString());
            //Console.WriteLine(System.IO.Directory.GetCurrentDirectory().ToString());
            log.LogRecord("清空缓存区");
        }
        #endregion

        #region 保存文件
        private void SaveFileMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "txt files(*.txt)|*.txt|xml files(*.xml)|*.xml|doc files(*.doc)|*.doc|All files(*.*)|*.*";//设置保存的文件格式
            saveFile.FilterIndex = 1;
            if (saveFile.ShowDialog() == DialogResult.OK)//如果点击OK Button
            {
                string localFilePath = saveFile.FileName.ToString();
                FileInfo fi = new FileInfo(localFilePath);
                fi.Delete();//先删除源文件
                FileStream fs = new FileStream(localFilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);//新建一个同名文件
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(fileTextBox.Text);//把编辑过的资料写入进去
                sw.Dispose();
                fs.Dispose();
                log.LogRecord("保存文件：" + saveFile.FileName.ToString());
                                
            }

        }
        #endregion

        #region 复制
        private void FileCopyItem_Click(object sender, EventArgs e)
        {


            try
            {
                FileInfo fileCopyFrom = new FileInfo(sorcetextBox1.Text);
                targettextBox1.Enabled = true;
                if (targettextBox1.Text != "")//判断目标文件夹是不是为空
                {
                    fileCopyFrom.CopyTo(targettextBox1.Text + sorcetextBox1.Text.Substring(sorcetextBox1.Text.LastIndexOf("\\")));//执行复制
                    //Console.WriteLine(targettextBox1.Text + sorcetextBox1.Text.Substring(sorcetextBox1.Text.LastIndexOf("\\")));
                    MessageBox.Show("Completed!");
                    log.LogRecord("复制文件：" +sorcetextBox1.Text+"复制到"+targettextBox1.Text);
                    
                }
                else
                {
                    MessageBox.Show("请选择目标文件加！");
                }                

            }
            catch (Exception)
            {

                if (sorcetextBox1.Text == "")//判断是否有选择源文件
                {
                    MessageBox.Show("请选择源文件！");
                }
                
            } 
            
        }
        #endregion

        #region 选择源文件
        private void sourcebutton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectFile = new OpenFileDialog();
            selectFile.Filter = "txt files(*.txt)|*.txt|xml files(*.xml)|*.xml|doc files(*.doc)|*.doc|All files(*.*)|*.*";//设置打开文件的格式
            selectFile.RestoreDirectory = true;//保存上次打开的路径
            selectFile.Title = "选择目标文件";
            if (selectFile.ShowDialog() == DialogResult.OK)
            {
                string selectFileFromPath = selectFile.FileName.ToString();
                sorcetextBox1.Text = selectFileFromPath;
            }

        }
        #endregion

        #region 选择目标文件夹
        private void targetbutton2_Click(object sender, EventArgs e)
        {
                FolderBrowserDialog copyFile = new FolderBrowserDialog();
                copyFile.ShowNewFolderButton = true;  

                if (copyFile.ShowDialog()==DialogResult.OK)
                {
                    string targetFileToPath = copyFile.SelectedPath.ToString();
                    targettextBox1.Text = targetFileToPath;
                }

        }
        #endregion

        #region 添加
        private void FileAppendItem_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo fileAppend = new FileInfo(sorcetextBox1.Text);
                // targettextBox1.Enabled = false;
                StreamWriter sw = fileAppend.AppendText();
                sw.Write("\r\n" + fileTextBox.Text);//添加内容到文件，内容输入在fileTextBox
                sw.Dispose();
                //File.AppendAllLines(sorcetextBox1.Text,(IEnumerable)fileTextBox.Text);
                    
                   // Console.WriteLine(targettextBox1.Text + sorcetextBox1.Text.Substring(sorcetextBox1.Text.LastIndexOf("\\")));
                    MessageBox.Show("Completed!");
                    log.LogRecord("添加内容到：" + sorcetextBox1.Text );

            }
            catch (Exception)
            {

                if (sorcetextBox1.Text == "")
                {
                    MessageBox.Show("请选择源文件！");
                }

            } 
        }
        #endregion

        #region 移动
        private void FileMoveItem_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo fileMove = new FileInfo(sorcetextBox1.Text);
                // targettextBox1.Enabled = false;
                if (targettextBox1.Text != "")
                {
                    fileMove.MoveTo(targettextBox1.Text + sorcetextBox1.Text.Substring(sorcetextBox1.Text.LastIndexOf("\\")));
                    // Console.WriteLine(targettextBox1.Text + sorcetextBox1.Text.Substring(sorcetextBox1.Text.LastIndexOf("\\")));
                    MessageBox.Show("Completed!");
                    log.LogRecord("移动文件：" + sorcetextBox1.Text + "移动到" + targettextBox1.Text);

                }
                else
                {
                    MessageBox.Show("请指定目标文件夹！");
                }
                                              
            }
            catch (Exception)
            {

                if (sorcetextBox1.Text == "")
                {
                    MessageBox.Show("请选择源文件！");
                }

            } 

        }
        #endregion

        #region 删除
        private void FileDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo fileDelete = new FileInfo(sorcetextBox1.Text);
                // targettextBox1.Enabled = false;
                
                if (MessageBox.Show("是否确认删除文件？","确认信息", MessageBoxButtons.OKCancel)==DialogResult.OK)
                {
                    fileDelete.Delete();
                    MessageBox.Show("Completed!");
                    log.LogRecord("删除文件：" + sorcetextBox1.Text );
                }
                    
                             

            }
            catch (Exception)
            {

                if (sorcetextBox1.Text == "")
                {
                    MessageBox.Show("请选择源文件！");
                }

            } 
        }
        #endregion



        private void FileSearchItem_Click(object sender, EventArgs e)
        {
           
        }

        #region 初始化功能加载
        private void FileForm3_Load(object sender, EventArgs e)
        {
            //log creatlog = new log();
            log.CreatDir();//创建Log目录
            log.CreatLog();//创建Log文档
        }
        #endregion

        #region 搜索

        private void 搜索ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ParentPath = targettextBox1.Text;
            listBox1.Items.Clear();
            TransferFile(ParentPath);

        }

        #endregion

        public void TransferFile(string path)
        {
            try
            {
                DirectoryInfo sdir = new DirectoryInfo(path);
                DirectoryInfo[] sdirs = sdir.GetDirectories();
                FileInfo[] sfiles = sdir.GetFiles();

                foreach (DirectoryInfo d in sdirs)
                {
                    //Console.WriteLine(d.FullName);
                    TransferFile(d.FullName);
                }

                foreach (FileInfo f in sfiles)
                {
                    listBox1.Items.Add(sdir +"\\"+ f.ToString());
                }
            }
            catch (Exception)
            {

                MessageBox.Show("");
            }

        }

    }
}
