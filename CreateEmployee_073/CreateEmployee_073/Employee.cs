using System;
using System.Collections.Generic;
using System.Text;

namespace CreateEmployee_073
{
    internal class Employee
    {
        public int Number { get; }
        public string Name { get; private set; }
        public Employee(int number, string name = "张三")
        {
            this.Number = number;
            this.Name = name;
        }
        public string GetInfo()
        {
            return string.Format("编号：{0}", this.Name);
        }
    }
}
