using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    class Program
    {
        enum Days { SAT=1 ,SUN,MON,TUE=1,WED,THU,FRI};
        static void Main(string[] args)
        {
            //Days d = Days.SUN;
            //Console.WriteLine(Convert.ToInt32(d));

            //Persen P1 = new Persen("熊大", 27);
            //P1.Display();
            //P1.SetName("熊二");
            //P1.SetAge(14);
            //P1.Display();

            Persen onePerson = new Persen();
            onePerson.Name = "田七";
            string strName = onePerson.Name;
            onePerson.Age = 20;
            int intAge = onePerson.Age;
            onePerson.Display();

            //P1 = new Persen();
            //P1.Display();
            //Console.ReadKey();

            //Employee oneEmployee = new Employee("李国明",23,"南京自动化", 4500);
            //oneEmployee.Display();
            //oneEmployee.SetName("田胜");
            //oneEmployee.SetAge(35);
            //oneEmployee.Display();

            //Test T1 = new Test(100, 200);
            //T1.x = 40;//引用实例字段采用方法：实例名.实例字段名
            //Test.cnt = 0;//引用静态字段采用方法:类名.静态字段名
            //int z = T1.y;//引用只读字段
            //z = Test.intMax;//引用常量
            Console.ReadKey();

        }
    }



    struct point
    {
        public int x, y;
    }

}
