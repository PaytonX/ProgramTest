using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Persen P1 = new Persen("熊大", 27);
            //P1.Display();
            //P1.SetName("熊二");
            //P1.SetAge(14);
            //P1.Display();

            //P1 = new Persen();
            //P1.Display();
            //Console.ReadKey();


        }
    }

    #region Person Class的完整例子
    class Persen
    {
        //设定私有变量，无法从Class外部修改
        private String name = "张三";
        private int age = 12;

        //在屏幕上打印信息
        public void Display()
        {
            Console.WriteLine("姓名：{0},年龄：{1}", name, age);
        }
        //设置名称方法
        public void SetName(String PersenName)
        {
            name = PersenName;
        }
        //设置年龄方法
        public void SetAge(int PersenAge)
        {
            age = PersenAge;
        }
        //构造函数
        public Persen(String Name,int Age)
        {
            name = Name;
            age = Age;
        }
        //构造函数重载
        public Persen()
        {
            name = "Gary";
            age = 12;
        }
    }
    #endregion

    struct point
    {
        public int x, y;
    }

}
