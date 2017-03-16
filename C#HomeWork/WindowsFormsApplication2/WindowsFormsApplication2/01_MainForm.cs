using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
           
            
            
            
        }

        private void comboBoxyuanxi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxzhuanye_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
           
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            姓名输入提示.IsBalloon = false;
            姓名输入提示.Show("请输入姓名,姓名不能为空！", this.textBox1);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            姓名输入提示.Hide(this.textBox1);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //checkedListBox1.SelectedIndex = 0;
            //checkedListBox1.SetSelected(0, true);
            //checkedListBox1.SetItemChecked(0,true);
            //checkedListBox1.Enabled = false;
            //timer1.Stop();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string txt2 = "";
           
            // Input Check
            if (textBox1.Text  != "")//如果名字不为空
            {
                txt2 = "姓名：" + textBox1.Text;

                #region Sex

                if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)
                {
                    if (radioButton1.Checked)// 性别输出
                    {
                        txt2 += "\r\n" + "性别：" + radioButton1.Text;
                    }
                    else if (radioButton2.Checked)
                    {
                        txt2 += "\r\n" + "性别：" + radioButton2.Text;
                    }
                    else
                    {
                        txt2 += "\r\n" + "性别：" + radioButton3.Text;
                    }
                    #region dateTime
                    if (dateTimePicker1.Value.Date < dateTimePicker2.Value.Date)
                    {
                        txt2 += "\r\n" + "出生日期：" + dateTimePicker1.Text + "\r\n" + "毕业日期：" + dateTimePicker2.Text;

                        if (comboBoxyuanxi.Text != "" && listBoxzhuanye.Text != "")
                        {
                            txt2 += "\r\n" + "院系：" + comboBoxyuanxi.Text + "\r\n" + "专业：" + listBoxzhuanye.Text ;

                            if (checkedListBox1.Text != "")
                            {
                                
                                string checklisttext = "";
                                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                                {

                                    if (checkedListBox1.GetItemChecked(i))
                                    {
                                        checklisttext += checkedListBox1.Items[i].ToString() + " "; 
                                    }
                                    
                                }


                                txt2 += "\r\n" + "兴趣还好：" + checklisttext.TrimEnd();
                                textBox2.Text = txt2;//输出结果
                            }
                            else
                            {
                                //Check interests
                                MessageBox.Show("请选择兴趣爱好！", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            
                        }
                        else
                        {
                            //Check Major
                            MessageBox.Show("请选择专业和院系！", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        

                        
                    }
                    else
                    {
                        //Check dateTime
                        MessageBox.Show("出生日期应小于毕业日期！", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    #endregion
                }
                else
                {
                        //Check Sex
                        MessageBox.Show("请选取性别！", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                #endregion




            }
            else//如果名字为空，则显示提示信息
            {
                MessageBox.Show("名字不能为空，请输入名字！", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

               
            }

            
           

           

            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsmenu_Click(object sender, EventArgs e)
        {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //关于
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C# Homework Edit By Pace 2016");
        }

        private void comboBoxyuanxi_TextChanged(object sender, EventArgs e)
        {
            
            switch (comboBoxyuanxi.Text.Trim())
            {
                case   "建筑与环境工程系":
                    listBoxzhuanye.Items.Clear();
                    listBoxzhuanye.Items.Add("建筑工程技术");
                    listBoxzhuanye.Items.Add("工程造价");
                    listBoxzhuanye.Items.Add("环境监测与治理技术");
                    listBoxzhuanye.Items.Add("园林工程技术");
                    listBoxzhuanye.Items.Add("消防工程技术");
                    listBoxzhuanye.Items.Add("工业分析与检验");
                    break;

                case "汽车工程系":
                    listBoxzhuanye.Items.Clear();
                    listBoxzhuanye.Items.Add("汽车制造与装配技术");
                    listBoxzhuanye.Items.Add("汽车运用技术");
                    listBoxzhuanye.Items.Add("汽车技术服务与营销");
                    break;

                case "管理系":
                    listBoxzhuanye.Items.Clear();
                    listBoxzhuanye.Items.Add("物流管理");
                    listBoxzhuanye.Items.Add("财务管理");
                    listBoxzhuanye.Items.Add("营销与策划");
                    listBoxzhuanye.Items.Add("初等教育");
                    listBoxzhuanye.Items.Add("学前教育");
                    break;

                case "机械系":
                    listBoxzhuanye.Items.Clear();
                    listBoxzhuanye.Items.Add("数控技术");
                    listBoxzhuanye.Items.Add("机械设计与制造");
                    listBoxzhuanye.Items.Add("模具设计与制造");
                    break;

                case "电子电气工程系":
                    listBoxzhuanye.Items.Clear();
                    listBoxzhuanye.Items.Add("应用电子技术");
                    listBoxzhuanye.Items.Add("电子信息工程技术");
                    listBoxzhuanye.Items.Add("电气自动化技术");
                    listBoxzhuanye.Items.Add("机电一体化技术");
                    listBoxzhuanye.Items.Add("微电子技术");
                    break;

                case "计算机科学系":
                    listBoxzhuanye.Items.Clear();
                    listBoxzhuanye.Items.Add("软件技术");
                    listBoxzhuanye.Items.Add("计算机网络技术");
                    listBoxzhuanye.Items.Add("动漫设计与制作");
                    listBoxzhuanye.Items.Add("计算机应用技术");
                    listBoxzhuanye.Items.Add("广告媒体开发");
                    listBoxzhuanye.Items.AddRange(new object[] { "电子商务", "楼宇智能化工程技术" });//另一种添加Item的方法，囧啊！前面的方法好傻的说
                    break;

                default:
                    break;
            }
        }

        private void checkedListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            

        }

        //版本信息
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2016/9/13  Ver1.00  基础控件练习完成\n"+
                            "2016/9/19  Ver1.01  字符串练习完成\n"+
                            "2016/10/02  Ver1.02  档案IO练习完成\n"
                
                
                            );
        }

        private void 字符串处理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringForm2 sfrm2 = new StringForm2(); //重复点击，生成多个相同窗口
            //if (!sfrm2.Created())
            //{
            //    sfrm2.Show();  
            //}
            
            sfrm2.Show();
            
            
        }

        private void 档案IOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileForm3 ffrm3 = new FileForm3();
            ffrm3.Show();
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void socketServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _04_SockerServerForm stserver = new _04_SockerServerForm();
            stserver.Show();
        }

        private void sockerClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _05_SocketClientForm stclient = new _05_SocketClientForm();
                stclient.Text = "SocketClient(" + Dns.GetHostName() + ")";//获取计算机名，并显示当Client窗口上
                stclient.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        
        
    }
}