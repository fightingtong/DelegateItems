using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegateConsole
{
    // 1 声明委托
    public delegate void NoParamNoReturnOutClass();

    public class MyDelegate
    {
        // 1 声明委托
        private delegate void NoParamNoReturn();

        private delegate void WithParamNoReturn(string name, int id, DateTime now);

        private delegate int NoParamWithReturn();

        private delegate MyDelegate WithParamWithReturn(string name);

        /// <summary>
        /// lesson1
        /// </summary>
        public static void ShowLesson1()
        {
            // 2 委托的实例化
            var method = new NoParamNoReturn(ShowSomething);
            // 3 委托实例的调用：method.Invoke() == method()功能一样
            method.Invoke();
            method();
        }

        /// <summary>
        /// lesson2
        /// </summary>
        public static void ShowLesson2()
        {
            var method = new NoParamWithReturn(GetSomething);

            // 多播委托
            // 按顺序添加到方法列表
            method += GetSomething;
            method += GetSomething;
            method += GetSomething;
            method += GetSomething;
            // 从方法列表的尾部去掉且只去掉一个完全匹配
            method -= GetSomething;

            Console.WriteLine("NoParamWithReturn()结果是 {0}", method());
        }

        private static void ShowSomething()
        {
            Console.WriteLine("这里是ShowSomething");
        }

        private static int GetSomething()
        {
            Console.WriteLine("这里是GetSomething");
            //Thread.Sleep(10);
            //return DateTime.Now.Millisecond;
            return 12;
        }
    }
}
