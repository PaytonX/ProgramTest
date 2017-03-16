using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class _05_SocketClientForm : Form
    {

        private Socket ClientConnect;
        private string ClientName;
        private Thread ClRecThread;

        private byte[] RecBuffer = new byte[4096];
        private byte[] Senbuffer = new byte[4096];
        private String SendStr;
        private String RecStr;

        private string[] RecStrArray = new string[50];

        public _05_SocketClientForm()
        {
            InitializeComponent();
            

           //Connect();
            
        }

        private void Connect()
        {
            //定义连接服务器IP地址
            IPAddress ServerIP = IPAddress.Parse("127.0.0.1");
            //定义端口
            int Port = 3000;
            //将IP地址和端口进行绑定
            IPEndPoint LocalEndPoint = new IPEndPoint(ServerIP, Port);
            //创建套接字连接服务器用于通信
            ClientConnect = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ClientConnect.Connect(LocalEndPoint);
            //发送Client连接信息给Server
            SendStr = "CONT|Null|" + Dns.GetHostName();
            Senbuffer = Encoding.UTF8.GetBytes(SendStr);
            ClientConnect.Send(Senbuffer, Senbuffer.Length, 0);

            ClRecThread = new Thread(new ThreadStart(RecieveData));
            ClRecThread.IsBackground = true;
            ClRecThread.Start();

         }


        private void RecieveData()
        {
            try
            {
                while (true)
                {
                    //int bufLen = 0;
                    //bufLen = ClientConnect.Available;
                    //ClientConnect.Receive(RecBuffer,bufLen,SocketFlags.None);
                    int RecbufLen = ClientConnect.Receive(RecBuffer);
                    
                    RecStr = Encoding.UTF8.GetString(RecBuffer,0,RecbufLen);

                    RecStrArray = RecStr.Split(new char[] { '|' });
                    switch (RecStrArray[0])
                    {
                        case "JOIN"://更新客户端UserList
                            if (!this.listBox1.Items.Contains(RecStrArray[2]))
                            {
                                this.listBox1.Items.Add(RecStrArray[2]);
                            }
                          
                            break;

                        case "REMV"://移除客户端Userlist
                            this.listBox1.Items.Remove(RecStrArray[2]);
                            break;

                        case "CHAT"://发聊天信息
                            this.richTextBoxClient.AppendText(RecStrArray[2] + "\r\n");
                            break;

                        case "PREV":
                            this.richTextBoxClient.AppendText( RecStrArray[2] + "\r\n");
                            break;
                        
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("客户端接收数据错误：" + ex.Message);
            }

        }

        private void _05_SocketClientForm_FormClosing(object sender, FormClosingEventArgs e)//关闭窗口
        {
            this.buttonDisconnect_Click(null, null);
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)//断开连接
        {
            this.buttonDisconnect.Enabled = false;
            this.buttonConnect.Enabled = true;

            SendStr = "DCON|Null|" + Dns.GetHostName();//发送Client连接信息给Server
            Senbuffer = Encoding.UTF8.GetBytes(SendStr);
            ClientConnect.Send(Senbuffer, Senbuffer.Length, 0);
            this.listBox1.Items.Clear();//清空UserList
        }

        private void buttonConnect_Click(object sender, EventArgs e)//连接服务器
        {
            Connect();
            this.buttonConnect.Enabled = false;
            this.buttonDisconnect.Enabled = true;
            //SendStr = "CONT|Null|" + Dns.GetHostName();//发送Client连接信息给Server
            //Senbuffer = Encoding.UTF8.GetBytes(SendStr);
            //ClientConnect.Send(Senbuffer, Senbuffer.Length, 0);
        }

        private void _05_SocketClientForm_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void buttonSend_Click(object sender, EventArgs e)//发送消息
        {
            if (this.textBox1.Text!=String.Empty)
            {
                    if (!checkBoxPrev.Checked)
                {
                    SendStr ="ALL|Null|"+ Dns.GetHostName() + ":" + this.textBox1.Text;
                    Senbuffer = Encoding.UTF8.GetBytes(SendStr);
                    ClientConnect.Send(Senbuffer);
                }
                else
                {
                    if (this.listBox1.SelectedItem.ToString()!="" )
                    {
                        int i = this.listBox1.SelectedItem.ToString().IndexOf("(");
                    if (this.listBox1.SelectedItem.ToString().Substring(0,i)!=Dns.GetHostName()&& this.listBox1.SelectedItem != "")
                    {
                        SendStr = "PREV|" + this.listBox1.SelectedItem.ToString().Substring(0,i) + "|" + Dns.GetHostName() + "(悄悄话):" + this.textBox1.Text;
                        Console.WriteLine(this.listBox1.SelectedItem);
                        Senbuffer = Encoding.UTF8.GetBytes(SendStr);
                        ClientConnect.Send(Senbuffer);

                        this.richTextBoxClient.AppendText(Dns.GetHostName() + "(悄悄话):" + this.textBox1.Text+"\r\n");
                    }
                    }

                    

                }
            }
            else
            {
                MessageBox.Show("不能发送空值！");
            }
        }

    }
}
