using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClass;
using MyTestProject;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
               
            Console.WriteLine("Введите число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Class1 class1 = new Class1();
            Console.WriteLine(class1.pf(a) + "Простые множители:" + Convert.ToString(a));

            UnitTest1 test = new UnitTest1();
            test.TestMethod1();
            

        }
    }
}