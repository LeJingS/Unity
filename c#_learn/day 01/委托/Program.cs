using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托
{
    public delegate void MyDelegate();
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate = new MyDelegate(Method);
            Console.WriteLine("/n");
            myDelegate.Invoke();
            MyDelegate myDelegate1 = Method;
            myDelegate1();
            myDelegate += Method;
            Action action = Method;//无参无返回值的委托
            Func<string> func = () => { return "我是一个方法"; };
            Action<int, string> action1; 
        }
        static void Method()
        {
            Console.WriteLine("我是一个方法");
        }
    }
}
