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
        private string xmlpath = System.Windows.Forms.Application.StartupPath.ToString() + @"\DBConfig.xml";
        DataTable drShop = new DataTable();
        
        DataTable drLineType = new DataTable();
        DataTable drLineID = new DataTable();


        public SQLForm()
        {
            InitializeComponent();
          
        }

        private void SQLForm_Load(object sender, EventArgs e)
        {
            XmlFileRead(xmlpath, "", "");
            //Loading Shop list box item
            for (int i = 0; i < drShop.Rows.Count; i++)
            {
                this.cmbShop.DataSource = drShop;
                this.cmbShop.DisplayMember = "ShopName";
                this.cmbShop.ValueMember = "ShopName";
                this.cmbShop.SelectedIndex = -1;
            }
        }


        private void btn_Open_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            if (fd.ShowDialog()==DialogResult.OK)
            {
                this.tbox_Path.Text = fd.SelectedPath.ToString();
            }
          

        }


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
            for (int i = 0; i < drShop.Rows.Count; i++)
            {
                this.cbox_LineTypeSelect.DataSource = drLineType;
                this.cbox_LineTypeSelect.DisplayMember = "LineType";
                this.cbox_LineTypeSelect.ValueMember = "LineType";
                this.cbox_LineTypeSelect.SelectedIndex = -1;
            }
        }

        public void XmlFileRead(string xmlptah, string xnodename, string arname)
        {
            drShop.Columns.Add("ShopName",typeof(string));
            drLineType.Columns.Add("LineType", typeof(string));
            XmlTextReader xdr = new XmlTextReader(xmlpath);

            while (xdr.Read())
            {
                if (xdr.NodeType == XmlNodeType.Element)
                {
                    for (int i = 0; i < xdr.AttributeCount; i++)
                    {
                        if (xdr.Name == "Shop")
                        {
                            //MessageBox.Show(xdr.GetAttribute(i));

                            drShop.Rows.Add(xdr.GetAttribute(i));

                        }
                        else if (xdr.Name == "LineType")
                        {
                            //MessageBox.Show(xdr.GetAttribute(i));

                            drLineType.Rows.Add(xdr.GetAttribute(i));

                        }
                    }

                }
            }
            

        }

    }



}
