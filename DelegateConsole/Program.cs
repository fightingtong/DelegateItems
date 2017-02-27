using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lesson1--------");
            MyDelegate.ShowLesson1();
            Console.WriteLine();

            Console.WriteLine("lesson2--------");
            MyDelegate.ShowLesson2();
            Console.WriteLine();

            Console.WriteLine("lesson3--------");
            Console.WriteLine("1、方法调用：");
            Greeting.SayHi("李雷", Greeting.PeopleType.Chinese);
            Greeting.SayHi("Li Lei", Greeting.PeopleType.American);
            Console.WriteLine();

            Console.WriteLine("2、委托调用：");
            var sayHi = new SayHiDelegate(Greeting.SayHiChinese);
            Greeting.SayHiInvoke("李雷", sayHi);
            var sayHiAmerican = new SayHiDelegate(Greeting.SayHiAmerican);
            Greeting.SayHiInvoke("Li Lei", sayHiAmerican);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
