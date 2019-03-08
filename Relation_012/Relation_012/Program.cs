using System;

namespace Relation_012
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数：");
            var num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个数：");
            var num2 = int.Parse(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("{0} 等于 {1}", num1, num2);
            }
            else if (num1 > num2)
            {
                Console.WriteLine("{0} 大于 {1}", num1, num2);
            }
            else
            {
                Console.WriteLine("{0} 小于 {1}", num1, num2);
            }
            Console.ReadKey();
        }
    }
}
