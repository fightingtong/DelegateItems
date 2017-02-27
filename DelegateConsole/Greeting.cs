using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateConsole
{
    /// <summary>
    /// 委托声明
    /// </summary>
    /// <param name="name"></param>
    public delegate void SayHiDelegate(string name);
    public class Greeting
    {
        /// <summary>
        /// 普通方法调用
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        public static void SayHi(string name, PeopleType type)
        {
            if (type == PeopleType.Chinese)
            {
                Console.WriteLine("早上好，{0}", name);
            }
            else if (type == PeopleType.American)
            {
                Console.WriteLine("Morning,{0}", name);
            }
        }

        public enum PeopleType
        {
            Chinese,
            American
        }

        /// <summary>
        /// 委托调用：逻辑分离，解除耦合
        /// </summary>
        /// <param name="name"></param>
        /// <param name="sayHi"></param>
        public static void SayHiInvoke(string name, SayHiDelegate sayHi)
        {
            sayHi(name);
        }

        public static void SayHiChinese(string name)
        {
            Console.WriteLine("早上好，{0}", name);
        }

        public static void SayHiAmerican(string name)
        {
            Console.WriteLine("Morning,{0}", name);
        }
    }

    
}
