using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    class Employee:Persen
    {
        private string department;
        private decimal salary;
        public Employee (string Name,int Age,string D,decimal S) : base(Name, Age)
        {
            department = D;
            salary = S;
        }

        public new void Display()
        {
            base.Display();
            Console.WriteLine("部门：{0}    薪金：{1}", department, salary);
        }

     }
   
} 

