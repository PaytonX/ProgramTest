using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication2
{
    public partial class _04_SockerServerForm : Form
    {
        //创建一个<IP地址,套接字>的键值对集合用于存放地址对应的套接字
       Dictionary<string,Socket> dictionarySocket = new Dictionary<string,Socket>();
        //创建一个<主机名，IP地址>的键值对集合用于存放主机名和对应的套接字
       Dictionary<string, string> dictionarySocketName = new Dictionary<string, string>();
        //接收缓存数据区
       byte[] RecBuffer = new byte[4096];
        //发送缓存数据区
       byte[] SenBuffer = new byte[4096];
        //接收字符串
       string RecStr;
        //发送字符串
       string SenStr;
        //接收字符串数组
       string[] RecStrArray = new string[4096];


       
        public _04_SockerServerForm()
        {
            InitializeComponent();
            
            Listen();
                                   
        }

        /// <summary>
        /// 服务器监听
        /// </summary>
        private void Listen()
        {
            try
            {
                //定义服务器的IP地址
                IPAddress ServerIP = IPAddress.Parse("127.0.0.1");
                //定义端口号
                int Port = 3000;
                //将IP地址和端口号绑定
                IPEndPoint LocalEndPoint = new IPEndPoint(ServerIP, Port);

                //创建一个套接字用于监听客户端的连接信息
                Socket ServerLister = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //将服务器的IP地址和端口 与 监听套接字绑定
                ServerLister.Bind(LocalEndPoint);
                //开始监听，最大监听数为50
                ServerLister.Listen(50);
                ShowMsg("开始监听");
                //新建一个监听线程，用于监听客户端的连接请求
                Thread ClientAcceptThread = new Thread(RecieveAccept);
                //设置为后台线程
                //ClientAcceptThread.IsBackground = true;
                //启动线程
                ClientAcceptThread.Start(ServerLister);
                
                
            }
            catch (Exception ex)
            {
                ShowMsg("监听异常：" + ex.Message);
                
            }
           

        }


        private void ShowMsg(string ShowStr)
        {
            this.richTextBox1.AppendText(ShowStr + "\r\n");
        }


        public void RecieveAccept(object O)
        {
            try
            {
                while (true)
                {
                    Socket s = O as Socket;
                    //连接请求，则创建一个新的套接字和该客户端进行发送接收消息
                    Socket ClientSocket =s.Accept();
                    if (!dictionarySocket.ContainsKey(ClientSocket.RemoteEndPoint.ToString()))
                    {
                        dictionarySocket.Add(ClientSocket.RemoteEndPoint.ToString(), ClientSocket);

                        ShowMsg(ClientSocket.RemoteEndPoint.ToString()+":连接成功");
                        
                    }
                    
                    

                   //新建一个接送消息线程，用于接送数据
                    Thread ReceiveDataThread = new Thread(RecieveData);
                    //该线程是后台线程
                    ReceiveDataThread.IsBackground = true;
                    //启动线程
                    ReceiveDataThread.Start(ClientSocket);

                    
                }


            }
            catch (Exception ex)
            {
                
                    ShowMsg("接收数据错误：" + ex.Message);
            }
          
        }

        /// <summary>
        /// 接收数据
        /// </summary>

        private void RecieveData(object O)
        {
            
            bool keepalive = true;
            
            Socket s = O as Socket; 
            //定义接收的数据长度
            int bufLen = 0;

           
                while (keepalive)
                {
                     try
                        {
                           
                           //获取客户端发送的数据长度
                            bufLen = s.Receive(RecBuffer);
                           
                            //将收到的数据转换为字符串
                            RecStr = Encoding.UTF8.GetString(RecBuffer,0,bufLen);
                            //RecStr = "ALL|Null|1:this is a test message";
                            
                        }
                         catch (Exception )
                         {

                             
                         }
                        
                        //如果没有收到客户端发送的数据则跳过
                         if (bufLen == 0)
                         {
                             continue;
                         }
                       //将收到的数据进行拆分

                         RecStrArray = RecStr.Split(new char[]{'|'});
                      
                         Console.WriteLine("command:"+RecStrArray[0]);

                            try
                            {
                                switch (RecStrArray[0])
                                {
                                    case "ALL"://转发所有信息
                                        foreach (Socket sendsocket in dictionarySocket.Values)
                                        {
                                            SenStr = "CHAT|Null|" + RecStrArray[2];
                                            SenBuffer = Encoding.UTF8.GetBytes(SenStr);
                                            sendsocket.Send(SenBuffer);
                                        }
                                        break;

                                    case "CONT":
                                        if (!dictionarySocketName.ContainsKey(RecStrArray[2]))
                                        {
                                            dictionarySocketName.Add(RecStrArray[2], s.RemoteEndPoint.ToString());
                                            ShowUserList(1, RecStrArray[2]);//Add Client,RecStrArray Saved ClientName
                                        }
                                        
                                        break;

                                    case "DCON":
                                        ShowUserList(2, RecStrArray[2]);//Cut Client,RecStrArray Saved ClientName
                                        keepalive = false;
                                        break;

                                    case "PREV":
                                        if (dictionarySocketName.ContainsKey(RecStrArray[1]))
                                        {
                                            SenStr = "PREV|Null|" + RecStrArray[2];
                                            SenBuffer = Encoding.UTF8.GetBytes(SenStr);
                                            dictionarySocket[dictionarySocketName[RecStrArray[1]]].Send(SenBuffer);
                                        }
                                        break;


                                    default:
                                        break;
                                }

                            }
                            catch (Exception ex)
                            {

                               ShowMsg("数据错误：" + ex.Message);
                            }

                            
                    
                }
            
        }


        /// <summary>
        /// 显示UserList
        /// </summary>
        private void ShowUserList(int func,string username)//func =1:add   func = 2:cut
        {
            try
            {
                switch (func)
                {
                    case 1://添加客户端
                        //将客户端添加进用户列表
                        this.listBoxServer.Items.Add(username + "(" + dictionarySocketName[username] + ")");


                        //将用户列表发给所有客户端
                        foreach (Socket sendsocket in dictionarySocket.Values)
                        {
                            for (int i = 0; i < this.listBoxServer.Items.Count; i++)
                            {
                                SenStr = "JOIN|Null|" + this.listBoxServer.Items[i].ToString();
                                SenBuffer = Encoding.UTF8.GetBytes(SenStr);
                                sendsocket.Send(SenBuffer);
                            }
                            //SenStr ="JOIN|Null|"+username + "(" + dictionarySocketName[username] + ")";
                            //SenBuffer = Encoding.UTF8.GetBytes(SenStr);
                            //sendsocket.Send(SenBuffer);

                        }



                        break;
                    case 2://移除客户端
                        if (dictionarySocketName.ContainsKey(RecStrArray[2]))
                        {
                            this.listBoxServer.Items.Remove(RecStrArray[2] + "(" + dictionarySocketName[RecStrArray[2]] + ")");
                            ShowMsg(dictionarySocketName[RecStrArray[2]] + ":断开连接");
                            dictionarySocket.Remove(dictionarySocketName[RecStrArray[2]]);//移除相关键值对
                        }
                        foreach (Socket sendsocket in dictionarySocket.Values)//给客户端发送移除命令
                        {
                            for (int i = 0; i < this.listBoxServer.Items.Count; i++)
                            {
                                SenStr = "REMV|Null|" + RecStrArray[2] + "(" + dictionarySocketName[RecStrArray[2]] + ")";
                                SenBuffer = Encoding.UTF8.GetBytes(SenStr);
                                sendsocket.Send(SenBuffer);
                            }
                        }

                        dictionarySocketName.Remove(RecStrArray[2]);//移除相关键值对


                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                
                
            }
            
            

        
        }

        private void _04_SockerServerForm_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

            

        

    }
}
