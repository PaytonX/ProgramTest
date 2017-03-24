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
using System.Xml;
using System.Threading;

namespace SQLRuningTool
{
    public partial class SQLForm : Form
    {
        #region 临时变量
        private string xmlpath = System.Windows.Forms.Application.StartupPath.ToString() + @"\DBConfig.xml";
        string DBconn = string.Empty;
        string[] shoplist = new string[256];
        string[] linetypelist = new string[256];
        string[] lineidlist = new string[1024];
        int shopcount = 0;
        int linetypecount = 0;
        int lineidcount = 0;
        #endregion

        public SQLForm()
        {
            InitializeComponent();
          
        }

        private void SQLForm_Load(object sender, EventArgs e)
        {
            XmlFileRead(xmlpath);
        #region 添加ShopList
            for (int i = 0; i < shopcount; i++)
            {
                this.cmbShop.Items.Add(shoplist[i]);
                this.cmbShop.SelectedIndex = -1;
            }
        #endregion          
        }

        #region 选取SQL路径
        private void btn_Open_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            if (fd.ShowDialog()==DialogResult.OK)
            {
                this.tbox_Path.Text = fd.SelectedPath.ToString();
            }

            GetSqlVersion();
        }
        #endregion

        #region 获取SQL文档
        public void GetSQLFile()
        {
            string filePath = this.tbox_Path.Text+@"\";
            
            DirectoryInfo floder = new DirectoryInfo(filePath);
            DirectoryInfo[] folderinfo = floder.GetDirectories();

            foreach (DirectoryInfo NextFloder in folderinfo)
            {
                FileInfo[] fileInfo = NextFloder.GetFiles();

                foreach (FileInfo NextFile in fileInfo)
                {
                    if (NextFile.Extension==".sql")
                    {
                        MessageBox.Show(NextFile.Name);
                    }
                    else
                    {
                        continue;
                    }
                }

            }
            

           





        }

        #endregion



        private void cmbShop_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cbox_LineTypeSelect.Items.Count>0)
            {
                this.cbox_LineTypeSelect.Items.Clear() ;
                this.cbox_LineTypeSelect.Text = string.Empty;
            }
            switch (this.cmbShop.Text)
            {
                case "CF":

                    for (int i = 0; i < linetypecount; i++)
                    {
                        if (linetypelist[i].StartsWith("F1"))
                        {
                            this.cbox_LineTypeSelect.Items.Add(linetypelist[i]);
                        }
                        
                    }
                  
                    break;
                case "CELL":
                    for (int i = 0; i < linetypecount; i++)
                    {
                        if (linetypelist[i].StartsWith("C1")||linetypelist[i].StartsWith("M1"))
                        {
                            this.cbox_LineTypeSelect.Items.Add(linetypelist[i]);
                        }

                    }
                    break;

                case "ARRAY":
                    for (int i = 0; i < linetypecount; i++)
                    {
                        if (linetypelist[i].StartsWith("A1"))
                        {
                            this.cbox_LineTypeSelect.Items.Add(linetypelist[i]);
                        }

                    }
                    break;

                default:
                    break;
            }




        }

        private void cbox_LineTypeSelect_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.LineNoSelect.Items.Count>0)
            {
                this.LineNoSelect.Items.Clear();
                this.LineNoSelect.Text = string.Empty;
            }
            for (int i = 0; i < lineidcount; i++)
            {
                if (lineidlist[i].StartsWith(this.cbox_LineTypeSelect.Text))
                {
                    this.LineNoSelect.Items.Add(lineidlist[i]);
                }
            }

        }

        private void LineNoSelect_SelectedValueChanged(object sender, EventArgs e)
        {
            GetSqlHost(this.LineNoSelect.Text);
        }

        public void XmlFileRead(string xmlptah)
        {
            
            XmlTextReader xdr = new XmlTextReader(xmlpath);

            while (xdr.Read())
            {
                if (xdr.NodeType == XmlNodeType.Element)
                {
                    for (int i = 0; i < xdr.AttributeCount; i++)
                    {
                        #region 获取Shop节点属性
                        if (xdr.Name == "Shop")
                        {
                            //MessageBox.Show(xdr.GetAttribute(i));
                            shoplist[shopcount] = xdr.GetAttribute(i).ToString().Trim();
                            shopcount++;

                        }
                        #endregion

                        #region 获取LineType
                        else if (xdr.Name == "LineType")
                        {
                            //MessageBox.Show(xdr.GetAttribute(i));

                            linetypelist[linetypecount] = xdr.GetAttribute(i).ToString().Trim();
                            linetypecount++;
                        }
                        #endregion

                        #region 获取LineID
                        else if (xdr.Name == "Line")
                        {
                            lineidlist[lineidcount] = xdr.GetAttribute(i).ToString().Trim();
                            lineidcount++;
                        }
                        #endregion


                        if (xdr.EOF)
                        {
                            xdr.Close();
                            xdr.Dispose();
                        }
                    }

                    
                }
                
            }

        }

        public void GetSqlHost(string LineID)
        {
            XmlTextReader xmlread = new XmlTextReader(xmlpath);

            while (xmlread.Read())
            {
                if (xmlread.NodeType == XmlNodeType.Element)
                {
                    if (xmlread.Name == "Line")
                    {
                        if (xmlread.GetAttribute("LineID").ToString()==LineID)
                        {
                            DBconn = xmlread.GetAttribute("DBConn").ToString();
                            MessageBox.Show(DBconn);
                        }
                    }
                }

            }
            
        }

        public void GetSqlVersion()
        {
            string path = this.tbox_Path.Text + @"\";
            DirectoryInfo dirsql = new DirectoryInfo(path);

            this.cbox_VersionSelect.Items.AddRange(dirsql.GetDirectories());
            //foreach (DirectoryInfo dir in dirsql.GetDirectories())
            //{
            //    this.cbox_VersionSelect.Items.Add(dir);
            //}
        }

        public void Sqlconn(string DBconn)
        {

        }

        
    }



}
