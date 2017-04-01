using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    #region Person Class的完整例子
    class Persen
    {
        //设定私有变量，无法从Class外部修改
        private String _name = "张三";
        private int _age = 12;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                _age = value;
            }
        }

        //在屏幕上打印信息
        public void Display()
        {
            Console.WriteLine("姓名：{0},年龄：{1}", Name, Age);
        }
        //设置名称方法
        //public void SetName(String PersenName)
        //{
        //    _name = PersenName;
        //}
        ////设置年龄方法
        //public void SetAge(int PersenAge)
        //{
        //    _age = PersenAge;
        //}
        //构造函数
        public Persen(String name, int age)
        {
            Name = name;
            Age = age;
        }
        //构造函数重载
        public Persen()
        {
            Name = "Gary";
            Age = 12;
        }
    }
    #endregion
}
