using System;

namespace Calculator_011
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数：");
            var num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入算术运算符：");
            var oper = Console.ReadLine();
            Console.WriteLine("请输入第二个数：");
            var num2 = int.Parse(Console.ReadLine());

            var result = 0;

            switch (oper)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "%":
                    result = num1 % num2;
                    break;
                default:
                    Console.WriteLine("运算符输入错误！");
                    return;
            }
            Console.WriteLine("{0} {1} {2} = {3}", num1, oper, num2, result);
            Console.ReadKey();
        }
    }
}
