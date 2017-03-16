using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class StringForm2 : Form
    {
        public StringForm2()
        {
            InitializeComponent();
        }

        //internal bool Created()
        //{
        //    throw new NotImplementedException();
        //}

        private void StrcomboBox1_TextChanged(object sender, EventArgs e)
        {
            //Form2:字符串功能类型和字符串功能选择
            switch (StrcomboBox1.Text)
            {
                case "A. 截取：Mid()、Right()、Left()":
                    StrcomboBox2.Items.Clear();//清除StrcomBox2 中的 Item                   
                    //StrcomboBox2.SelectedItem = 1;
                    StrcomboBox2.Items.AddRange(new object[] {"Mid()","Right()","Left()"} );// 向里面添加新的Item
                    StrcomboBox2.Text = StrcomboBox2.Items[0].ToString();//将其当前选项改变为Item第一项
                    break;
                case "B. 合併：&、+":
                    StrcomboBox2.Items.Clear();
                    //StrcomboBox2.SelectionStart = 1;
                    StrcomboBox2.Items.AddRange(new object[] {"&","+"} );
                    StrcomboBox2.Text = StrcomboBox2.Items[0].ToString();
                    break;
                case "C. 搜尋：Instr()、InstrRev()":
                    StrcomboBox2.Items.Clear();
                    //StrcomboBox2.SelectionStart = 1;
                    StrcomboBox2.Items.AddRange(new object[] { "Instr()", "InstrRev()" });
                    StrcomboBox2.Text = StrcomboBox2.Items[0].ToString();
                    break;
                case "D. 取代：Replace()":
                    StrcomboBox2.Items.Clear();
                    //StrcomboBox2.SelectionStart = 1;
                    StrcomboBox2.Items.AddRange(new object[] { "Replace()" });
                    StrcomboBox2.Text = StrcomboBox2.Items[0].ToString();
                    break;
                case "E. 轉換：Val()、Hex()、Asc()、UCase()、Lcase()":
                    StrcomboBox2.Items.Clear();
                    //StrcomboBox2.SelectionStart = 1;
                    StrcomboBox2.Items.AddRange(new object[] { "Val()", "Hex()", "Asc()", "UCase()", "LCase()" });
                    StrcomboBox2.Text = StrcomboBox2.Items[0].ToString();
                    break;
                case "F. 比對：StrComp()":
                    StrcomboBox2.Items.Clear();
                    //StrcomboBox2.SelectionStart = 1;
                    StrcomboBox2.Items.AddRange(new object[] { "StrComp()" });
                    StrcomboBox2.Text = StrcomboBox2.Items[0].ToString();
                    break;
                case "G. 去空白：Ltrim()、Rtrim()、Trim()":
                    StrcomboBox2.Items.Clear();
                    //StrcomboBox2.SelectionStart = 1;
                    StrcomboBox2.Items.AddRange(new object[] { "Ltrim()", "Rtrim()", "Trim()" });
                    StrcomboBox2.Text = StrcomboBox2.Items[0].ToString();
                    break;
                case "H. 格式化：Format()":
                    StrcomboBox2.Items.Clear();
                    //StrcomboBox2.SelectionStart = 1;
                    StrcomboBox2.Items.AddRange(new object[] { "Format()" });
                    StrcomboBox2.Text = StrcomboBox2.Items[0].ToString();
                    
                    break;


                default:
                    break;
            }
        }

        private void StrcomboBox2_TextChanged(object sender, EventArgs e)
        {
            switch (StrcomboBox2.Text)
            {
                //A. 截取：Mid()、Right( )、Left( )
                case "Mid()":
                    Strlabel1.Text = "StartIndex:";
                    Strlabel2.Text = "length：";
                    StrtextBox3.Enabled = false;
                    break;

                case "Right()":
                    Strlabel1.Text = "参数1:";
                    StrtextBox1.Enabled = false;
                    Strlabel2.Text = "length：";
                    StrtextBox3.Enabled = false;
                    break;

                case "Left()":
                    Strlabel1.Text = "参数1:";
                    StrtextBox1.Enabled = false;
                    Strlabel2.Text = "length：";
                    StrtextBox3.Enabled = false;
                    break;

                //B. 合併：&、+
                case "&":
                    Strlabel1.Text = "参数1:";
                    Strlabel2.Text = "参数2：";
                    StrtextBox3.Enabled = false;
                    StrtextBoxinput.Enabled = false;
                    break;

                case "+":
                    
                    Strlabel1.Text = "参数1:";
                    Strlabel2.Text = "参数2：";
                    StrtextBox3.Enabled = false;
                    StrtextBoxinput.Enabled = false;
                    break;

                   // C. 搜尋：Instr( )、InstrRev( )
                case "Instr()":

                    Strlabel1.Text = "InString:";
                    Strlabel2.Text = "Index";
                    StrtextBox3.Enabled = false;
                    break;


                case "InstrRev()":
                    Strlabel1.Text = "InString:";
                    Strlabel2.Text = "Index";
                    StrtextBox3.Enabled = false;
                    
                    break;
                //D. 取代：Replace( )
                case "Replace()":
                    Strlabel1.Text = "Find:";
                    Strlabel2.Text = "ReplaceWith:";
                    StrtextBox3.Enabled = false;
                    break;

                //E. 轉換：Val( )、Hex( )、Asc( )、UCase( )、Lcase( )
                case "Val()":
                    Strlabel1.Text = "参数1：";
                    Strlabel2.Text = "参数2：";
                    Strlabel3.Text = "参数3：";
                    StrtextBox1.Enabled = false;
                    StrtextBox2.Enabled = false;
                    StrtextBox3.Enabled = false;
                    break;

                case "Hex()":
                    Strlabel1.Text = "参数1：";
                    Strlabel2.Text = "参数2：";
                    Strlabel3.Text = "参数3：";
                    StrtextBox1.Enabled = false;
                    StrtextBox2.Enabled = false;
                    StrtextBox3.Enabled = false;
                    break;

                case "Asc()":
                    Strlabel1.Text = "参数1：";
                    Strlabel2.Text = "参数2：";
                    Strlabel3.Text = "参数3：";
                    StrtextBox1.Enabled = false;
                    StrtextBox2.Enabled = false;
                    StrtextBox3.Enabled = false;
                    break;
                    
                case "UCase()":
                    Strlabel1.Text = "参数1：";
                    Strlabel2.Text = "参数2：";
                    Strlabel3.Text = "参数3：";
                    StrtextBox1.Enabled = false;
                    StrtextBox2.Enabled = false;
                    StrtextBox3.Enabled = false;
                    break;

                case "LCase()":
                    Strlabel1.Text = "参数1：";
                    Strlabel2.Text = "参数2：";
                    Strlabel3.Text = "参数3：";
                    StrtextBox1.Enabled = false;
                    StrtextBox2.Enabled = false;
                    StrtextBox3.Enabled = false;
                    break;

                //F. 比對：StrComp( )
                case "StrComp()":
                    Strlabel1.Text = "String1：";
                    Strlabel2.Text = "String2：";
                    Strlabel3.Text = "参数3：";
                    StrtextBoxinput.Enabled = false;
                    StrtextBox3.Enabled = false;
                    break;

                // G. 去空白：Ltrim( )、Rtrim( )、Trim( )
                case "Ltrim()":
                    Strlabel1.Text = "参数1：";
                    Strlabel2.Text = "参数2：";
                    Strlabel3.Text = "参数3：";
                    StrtextBox1.Enabled = true;
                    StrtextBox2.Enabled = false;
                    StrtextBox3.Enabled = false;
                    break;

                case "Rtrim()":
                    Strlabel1.Text = "参数1：";
                    Strlabel2.Text = "参数2：";
                    Strlabel3.Text = "参数3：";
                    StrtextBox1.Enabled = true;
                    StrtextBox2.Enabled = false;
                    StrtextBox3.Enabled = false;
                    break;

                case "Trim()":
                    Strlabel1.Text = "参数1：";
                    Strlabel2.Text = "参数2：";
                    Strlabel3.Text = "参数3：";
                    StrtextBox1.Enabled = true;
                    StrtextBox2.Enabled = false;
                    StrtextBox3.Enabled = false;
                    break;
                //H. 格式化：Format( )



                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string reslut = "";
            
            switch (StrcomboBox2.Text)
            {
                //A. 截取：
                //Mid(): 从中截取字符串
                //Right():从右截取字符串
                //Left():从左截取字符串
                #region mid()
                case "Mid()":
                    StrtextBoxoutput.Text = "";                                  
                    try
                    {
                         if (StrtextBox2.Text != "")
                         {
                             reslut = StrtextBoxinput.Text.Substring(Convert.ToInt32(StrtextBox1.Text), Convert.ToInt32(StrtextBox2.Text));
                             StrtextBoxoutput.Text = reslut;
                         }
                         else
                         {
                             reslut = StrtextBoxinput.Text.Substring(Convert.ToInt32(StrtextBox1.Text));
                             StrtextBoxoutput.Text = reslut;
                         }

                    }
                    catch (Exception)
                    {
                        if (StrtextBoxinput.Text == "")
                        {
                            MessageBox.Show("请输入待处理的字符串！");
                        }
                        else if (StrtextBox1.Text == "" && StrtextBox2.Text == "")
                        {
                            MessageBox.Show("请输入参数：Mid（StartIdex,Length） or  Mid(Length)");
                        }
                        else if (isNotNumber(StrtextBox1.Text)&&isNotNumber(StrtextBox2.Text))
                        {
                            MessageBox.Show("参数类型不对！");
                        }
                        else if (Convert.ToInt32(StrtextBox1.Text) >= StrtextBoxinput.Text.Length)
                        {
                            MessageBox.Show("StartIndex必须小于待处理字符串长度！(Index从0开始计算)");
                        }
                        else if ((Convert.ToInt32(StrtextBox2.Text) + Convert.ToInt32(StrtextBox1.Text)) > StrtextBoxinput.Text.Length)
                        {
                            MessageBox.Show("Length超过待处理字符串长度！");
                        }
                    }     
                    break;
                #endregion

                #region Right()
                case "Right()":
                    StrtextBoxoutput.Text = "";
                    try
                    {
                        reslut = StrtextBoxinput.Text.Substring(StrtextBoxinput.Text.Length - Convert.ToInt32(StrtextBox2.Text), Convert.ToInt32(StrtextBox2.Text));
                        StrtextBoxoutput.Text = reslut;
                    }
                    catch (Exception)
                    {
                        if (StrtextBoxinput.Text == "")
                        {
                            MessageBox.Show("请输入待处理的字符串！");
                        }
                        else if (StrtextBox2.Text == "")
                        {
                            MessageBox.Show("请输入参数：Right（Length）");
                        }
                        else if (isNotNumber(StrtextBox1.Text) && isNotNumber(StrtextBox2.Text))
                        {
                            MessageBox.Show("参数类型不对！");
                        }
                        else if (Convert.ToInt32(StrtextBox2.Text) > StrtextBoxinput.Text.Length)
                        {
                            MessageBox.Show("Length必须小于待处理字符串长度！");
                        }
                        
                        
                    }
                                               
                    break;
                #endregion

                #region Left()
                case "Left()":
                    StrtextBoxoutput.Text = "";
                    try
                    {
                        reslut = StrtextBoxinput.Text.Substring(0, Convert.ToInt32(StrtextBox2.Text));
                        StrtextBoxoutput.Text = reslut;
                    }
                    catch (Exception)
                    {
                        if (StrtextBoxinput.Text == "")
                        {
                            MessageBox.Show("请输入待处理的字符串！");
                        }
                        else if (StrtextBox2.Text == "")
                        {
                            MessageBox.Show("请输入参数：Left（Length）");
                        }
                        else if (isNotNumber(StrtextBox1.Text) && isNotNumber(StrtextBox2.Text))
                        {
                            MessageBox.Show("参数类型不对！");
                        }
                        else if (Convert.ToInt32(StrtextBox2.Text) > StrtextBoxinput.Text.Length)
                        {
                            MessageBox.Show("Length必须小于待处理字符串长度！");
                        }
                    }                    
                    break;
                #endregion


                //B. 合併：
                //&
                //+
                #region 合并
                case "&":
                    StrtextBoxoutput.Text = "";
                    try
                    {
                        reslut = StrtextBox1.Text + StrtextBox2.Text;
                        StrtextBoxoutput.Text = reslut;
                    }
                    catch (Exception)
                    {
                        if (StrtextBoxinput.Text == "")
                        {
                            MessageBox.Show("请输入待处理的字符串！");
                        }
                        else if (StrtextBox2.Text == "" && StrtextBox1.Text == "")
                        {
                            MessageBox.Show("请输入参数!");
                        }

                    }
                    break;

                case "+":
                    StrtextBoxoutput.Text = "";
                    try
                    {
                        reslut = StrtextBox1.Text + StrtextBox2.Text;
                        StrtextBoxoutput.Text = reslut;
                    }
                    catch (Exception)
                    {
                        if (StrtextBoxinput.Text == "")
                        {
                            MessageBox.Show("请输入待处理的字符串！");
                        }
                        else if (StrtextBox2.Text == "" && StrtextBox1.Text == "")
                        {
                            MessageBox.Show("请输入参数!");
                        }

                    }
                    break;
                #endregion

                // C. 搜尋：Instr( ):从左边开始搜索
                //、InstrRev( )：从右边开始搜索
                #region Instr()
                case "Instr()":
                    try
                    {
                        reslut = (StrtextBoxinput.Text.IndexOf(StrtextBox1.Text,(Convert.ToInt32(StrtextBox2.Text)-1))+1).ToString();//Instr()返回值：str.indexof()返回值 + 1；
                        if (reslut == "0")
                        {
                            StrtextBoxoutput.Text = "没有搜索的字符串：" + reslut;
                        }
                        else
                        {
                            StrtextBoxoutput.Text = "搜索的字符串所在位置：" + reslut;
                        }

                    }
                    catch (Exception)
                    {
                        if (StrtextBoxinput.Text == "")
                        {
                            MessageBox.Show("请输入待处理的字符串！");
                        }
                        else if (StrtextBox2.Text == "" || StrtextBox1.Text == "")
                        {
                            MessageBox.Show("请输入参数：Instr（Instring ,Index）");
                        }
                        else if (isNotNumber(StrtextBox2.Text))
                        {
                            MessageBox.Show("参数类型不对！");
                        }
                        else if (Convert.ToInt32(StrtextBox2.Text) > StrtextBoxinput.Text.Length)
                        {
                            MessageBox.Show("Length必须小于待处理字符串长度！");
                        }
                        
                    }
                    break;
                #endregion

                #region InstrRev()
                case "InstrRev()":
                    try
                    {
                        reslut = (StrtextBoxinput.Text.LastIndexOf(StrtextBox1.Text,(Convert.ToInt32(StrtextBox2.Text)-1))+1).ToString();
                        if (reslut == "0")
                        {
                            StrtextBoxoutput.Text = "没有搜索的字符串：" + reslut;
                        }
                        else
                        {
                            StrtextBoxoutput.Text = "搜索的字符串所在位置：" + reslut;
                        }
                    }
                    catch (Exception)
                    {
                        if (StrtextBoxinput.Text == "")
                        {
                            MessageBox.Show("请输入待处理的字符串！");
                        }
                        else if (StrtextBox2.Text == "" || StrtextBox1.Text == "")
                        {
                            MessageBox.Show("请输入参数：InstrRev（Instring ,Index）");
                        }
                        else if (isNotNumber(StrtextBox2.Text))
                        {
                            MessageBox.Show("参数类型不对！");
                        }
                        else if (Convert.ToInt32(StrtextBox2.Text) > StrtextBoxinput.Text.Length)
                        {
                            MessageBox.Show("Length必须小于待处理字符串长度！");
                        }
                        
                    }
                    break;
                #endregion

                //D. 取代：Replace( )
                #region Replace()
                case "Replace()":
                    try
                    {
                        reslut = StrtextBoxinput.Text.Replace(StrtextBox1.Text,StrtextBox2.Text);
                        StrtextBoxoutput.Text = reslut;
                    }
                    catch (Exception)
                    {
                        if (StrtextBoxinput.Text == "")
                        {
                            MessageBox.Show("请输入待处理的字符串！");
                        }
                        else if (StrtextBox2.Text == "" || StrtextBox1.Text == "")
                        {
                            MessageBox.Show("请输入参数：Replace（Find ,ReplaceWith）");
                        }
                        //else if (isNotNumber(StrtextBox2.Text))
                        //{
                        //    MessageBox.Show("参数类型不对！");
                        //}
                        //else if (Convert.ToInt32(StrtextBox2.Text) > StrtextBoxinput.Text.Length)
                        //{
                        //    MessageBox.Show("Length必须小于待处理字符串长度！");
                        //}
                        
                    }
                    break;
                #endregion

                //E. 轉換：Val( )、Hex( )、Asc( )、UCase( )、Lcase( )
                #region Val()
                case "Val()":
                    try
                    {
                       
                        foreach (char myChar in StrtextBoxinput.Text.ToCharArray())
                        {
                            
                            if (isNumber(myChar))
                            {
                                reslut += myChar; 
                            }
                        }
                        StrtextBoxoutput.Text = reslut;
                    }
                    catch (Exception)
                    {
                        if (StrtextBoxinput.Text == "")
                        {
                            MessageBox.Show("请输入待处理的字符串！");
                        }
                        
                    }

                    break;
                #endregion

                #region Hex()

                case "Hex()":
                    try
                    {
                        int intresult = Convert.ToInt32(StrtextBoxinput.Text);
                        reslut = string.Format("{0:X}", intresult);
                        StrtextBoxoutput.Text = reslut;
                        
                    }
                    catch (Exception)
                    {
                        if (StrtextBoxinput.Text == "")
                        {
                            MessageBox.Show("请输入待处理的字符串！");
                        }
                        else if (isNotNumber(StrtextBoxinput.Text))
                        {
                            MessageBox.Show("参数类型不对！");
                        }
                        
                    }
                    break;
                #endregion

                #region Asc（）
                case "Asc()":
                    try
                    {

                        //具体原理待查询学习
                        byte[] array = System.Text.Encoding.ASCII.GetBytes(StrtextBoxinput.Text.Trim());
                        for (int i = 0; i <StrtextBoxinput.Text.Length; i++)
                        {
                            reslut += Convert.ToString((int)array[i]);
                        }
                        StrtextBoxoutput.Text = reslut;
                    }
                    catch (Exception)
                    {
                        if (StrtextBoxinput.Text == "")
                        {
                            MessageBox.Show("请输入待处理的字符串！");
                        }
                        
                    }
                    break;
                #endregion

                #region Ucase()
                case "UCase()":
                    try
                    {

                        reslut = StrtextBoxinput.Text.ToUpper();
                        StrtextBoxoutput.Text = reslut;
                    }
                    catch (Exception)
                    {
                        if (StrtextBoxinput.Text == "")
                        {
                            MessageBox.Show("请输入待处理的字符串！");
                        }

                    }
                    break;
                #endregion

                #region LCase()
                case "LCase()":
                    try
                    {

                        reslut = StrtextBoxinput.Text.ToLower();
                        StrtextBoxoutput.Text = reslut;
                    }
                    catch (Exception)
                    {
                        if (StrtextBoxinput.Text == "")
                        {
                            MessageBox.Show("请输入待处理的字符串！");
                        }

                    }
                    break;
                #endregion

                //F. 比對：StrComp( )
                #region StrComp()
                case "StrComp()":
                    try
                    {
                        reslut = Convert.ToString(StrtextBox1.Text.CompareTo(StrtextBox2.Text));
                        if (Convert.ToInt32(reslut)>0)
                        {
                            StrtextBoxoutput.Text = "The first string is greater than the second string!";
                        }
                        else if (Convert.ToInt32(reslut)==0)
                        {
                            StrtextBoxoutput.Text = "The strings have the same value!";
                        }
                        else
                        {
                            StrtextBoxoutput.Text = "The second string is greater than the first string!";
                        }
                    }
                    catch (Exception)
                    {
                         if (StrtextBox2.Text == "" || StrtextBox1.Text == "")
                        {
                            MessageBox.Show("请输入参数：Strcomp（string1 ,String2）");
                        }
                        
                    }
                    break;
                #endregion

                // G. 去空白：Ltrim( )、Rtrim( )、Trim( )
                #region Trim()
                case "Ltrim()":
                    try
                    {
                        reslut = StrtextBoxinput.Text.TrimStart(StrtextBox1.Text.ToCharArray());
                        StrtextBoxoutput.Text = reslut;
                    }
                    catch (Exception)
                    {
                        if (StrtextBoxinput.Text == "")
                        {
                            MessageBox.Show("请输入待处理的字符串！");
                        }
                        
                    }
                    break;

                case "Rtrim()":
                    try
                    {
                        reslut = StrtextBoxinput.Text.TrimEnd(StrtextBox1.Text.ToCharArray());
                        StrtextBoxoutput.Text = reslut;
                    }
                    catch (Exception)
                    {
                        if (StrtextBoxinput.Text == "")
                        {
                            MessageBox.Show("请输入待处理的字符串！");
                        }

                    }
                    break;

                case "Trim()":
                    try
                    {
                        reslut = StrtextBoxinput.Text.Trim(StrtextBox1.Text.ToCharArray());
                        StrtextBoxoutput.Text = reslut;
                    }
                    catch (Exception)
                    {
                        if (StrtextBoxinput.Text == "")
                        {
                            MessageBox.Show("请输入待处理的字符串！");
                        }

                    }
                    break;
                #endregion

                //H. 格式化：Format( )

                default:
                    break;
            }
            //SaveFileDialog sf = new SaveFileDialog();
            //sf.ShowDialog();
        }

        private void StringForm2_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// 判断输入的参数是不是指定的类型
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static bool isNotNumber(string message)
        {
            try
            {
                Convert.ToInt32(message);
                return false;
            }
            catch (Exception)
            {

                return true;
            }
        }

        public static bool isNumber(char myChar)
        {
            try
            {
                Convert.ToInt32(myChar.ToString());
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        //函数说明
        private void StrtextBoxoutput_MouseEnter(object sender, EventArgs e)
        {
            switch (StrcomboBox2.Text)
            {
                    //Instr 中Index的计算是从1开始，和C#中Indexof（）计算方式不同
                case "Instr()":
                    if (StrtextBoxoutput.Text != "")
                    {
                        toolTip1.Show("Index 从1开始计算，第一个字符Index为1.", StrtextBoxoutput);
                    }
                    
                    break;
                //Instr 中Index的计算是从1开始，和C#中LastIndexof（）计算方式不同
                case "InstrRev()":
                    if (StrtextBoxoutput.Text != "")
                    {
                        toolTip1.Show("Index 从1开始计算，第一个字符Index为1.", StrtextBoxoutput);
                    }

                    break;
                default:
                    break;
            }
        }
    }
}
