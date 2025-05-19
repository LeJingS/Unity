using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace 特性
{
    // 自定义特性,命名是以Attribute结尾，引用时可以省略
    // AttributeTargets 特性能使用在哪， AllowMultiple 是否允许多个特性实例在同一个目标上实现 ，
    // Inherited特性能否被继承和重写函数使用
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct,AllowMultiple =true,Inherited =true)]
    class MyCustomAttribute : Attribute
    {
        // 特性成员，一般根据需求进行定义
        public string info;

        public MyCustomAttribute(string info)
        {
            this.info = info;
        }
    }
    // 使用特性
    [MyCustom("我是类")]

    class MyClass
    {
        // 使用特性
        //[MyCustomAttribute("我是函数")]
        public void MyMethod()
        {
            Console.WriteLine("我是自定义特性");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // 判断类是否有特性，只判断类上的
            MyClass myClass = new MyClass();
            Type type = myClass.GetType();
            // false表示不搜索继承链
            if(type.IsDefined(typeof(MyCustomAttribute), false))
            {
                Console.WriteLine("类上存在MyCustomAttribute特性");
            }

            object[] array = type.GetCustomAttributes(true);
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] is MyCustomAttribute)
                {
                    Console.WriteLine((array[i] as MyCustomAttribute).info);
                }
            }
        }
    }
}
