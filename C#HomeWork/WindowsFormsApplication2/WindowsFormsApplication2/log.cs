using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication2
{
    class log
    {

        #region Log记录
        public static void LogRecord(string action)
        {
            string Logfile = System.Windows.Forms.Application.StartupPath.ToString() + "\\Log\\" + DateTime.Today.Date.ToString("yyyyMMdd") + ".txt";
            //定义Log File存放地址
            FileStream logfs = new FileStream(Logfile, FileMode.Append, FileAccess.Write);
            StreamWriter logsw = new StreamWriter(logfs);
            logsw.WriteLine(DateTime.Now.ToString()+"  "+action);
            //以指定格式写入Log：时间： 操作
            logsw.Dispose();
            logfs.Dispose();


        }
        #endregion

        #region 创建Log目录
        public static void CreatDir()
        {
            string creatDirPath = System.Windows.Forms.Application.StartupPath.ToString() + "\\Log\\" ;
            //定义Log 目录穿件地址
            Console.WriteLine(creatDirPath);
            if (! Directory.Exists(creatDirPath))
            {
                //DirectoryInfo creatDir = new DirectoryInfo(creatDirPath);
                //creatDir.Create();
                Directory.CreateDirectory(creatDirPath);
                //创建目录

            }
          //  DirectoryInfo creatDir = new DirectoryInfo();
        }
        #endregion

        #region 创建Log文件
        public static void CreatLog()
        {
            string creatLogFile = System.Windows.Forms.Application.StartupPath.ToString() + "\\Log\\" + DateTime.Today.Date.ToString("yyyyMMdd") + ".txt";
            //定义Log文件创建地址
            Console.WriteLine(creatLogFile);
            if (!File.Exists(creatLogFile))
            {
                File.Create(creatLogFile);//创建Log文件
                
            }

        }
        #endregion

    }
}
