using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace 反射
{
    class Test
    {
        private int i = 1;
        public int j = 0;
        public string str = "123";

        public Test() { }
        public Test(int i) {this.i = i; }
        public Test(int i,string str):this(i) { this.str = str; }

        public void speak()
        {
            Console.WriteLine();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Type
            //// 是类的信息类
            //// 1. 获取Type
            //// 1.1 object中的方法
            //int a = 1;
            //Type type = a.GetType();
            //Console.WriteLine(type);
            //// 1.2 通过typeof关键字，传入类名
            //Type type2 = typeof(int);
            //Console.WriteLine(type2);
            //// 1.3 通过类的名字,必须包含命名空间不然找不到
            //Type type3 = Type.GetType("System.Int32");
            //Console.WriteLine(type3);
            //// 虽然有三个type 但指向的堆内存空间都是一样的

            //// 2. 得到类的程序集信息
            //Console.WriteLine(type.Assembly);
            //Console.WriteLine(type2.Assembly);
            //Console.WriteLine(type3.Assembly);

            //// 3. 获取类中的所有公共成员
            //Type t = typeof(Test);
            //MemberInfo[] infos = t.GetMembers();
            //Console.WriteLine("所有公共成员");
            //for (int i = 0; i < infos.Length; i++)
            //{
            //    Console.WriteLine(infos[i]);
            //}

            //// 4.1 获取类的公共构造函数并调用
            //ConstructorInfo[] constructors = t.GetConstructors();
            //Console.WriteLine("所有构造函数");
            //for (int i = 0; i < constructors.Length; i++)
            //{
            //    Console.WriteLine(constructors[i]);
            //}
            //// 4.2 获取其中一个构造函数并执行
            //// 得到无参构造
            //ConstructorInfo info = t.GetConstructor(new Type[0]);
            //// 执行无参构造
            //Test obj = info.Invoke(null) as Test;
            //Console.WriteLine(obj.j);

            //// 得到有参构造
            //ConstructorInfo info2 = t.GetConstructor(new Type[] { typeof(int), typeof(string) });
            //obj = info2.Invoke(new object[] { 2, "构造成功" }) as Test;
            //Console.WriteLine(obj.str);

            //// 5 获取类的公共成员变量
            //// 1. 得到所有的
            //FieldInfo[] fields = t.GetFields();
            //Console.WriteLine("所有公共成员变量");
            //for (int i = 0; fields.Length > i; i++)
            //{
            //    Console.WriteLine(fields[i]);
            //}
            //// 2. 得到指定的
            //FieldInfo infoJ = t.GetField("j");
            //Console.WriteLine(infoJ);
            //// 3. 通过反射设置和获取值
            //Test test = new Test();
            //test.j = 99;
            //test.str = "222";
            //// 通过反射获取值
            //Console.WriteLine(infoJ.GetValue(test));
            //// 通过反射设置值
            //infoJ.SetValue(test, 100);
            //Console.WriteLine(infoJ.GetValue(test));
            //// 6. 获取类的公共成员方法
            //Type strType = typeof(string);
            //// 6.1 如果存在方法重载，则返回所有重载方法
            ////MethodInfo[] methods = strType.GetMethods();
            ////for(int i = 0; i < methods.Length; i++)
            ////{
            ////    Console.WriteLine(methods[i]);
            ////}
            //// 6.2 获取其中一个方法并执行
            //MethodInfo subStr = strType.GetMethod("Substring",
            //    new Type[] { typeof(int), typeof(int) });
            //// 执行方法
            //string str = "hello world";
            //Console.WriteLine(subStr.Invoke(str, new object[] { 0, 5 }));
            //Console.WriteLine(str);
            //// 截取方法

            #endregion

            #region Assembly
            // 程序集信息类
            // 主要用来加载其他程序集类
            // 1. 获取程序集信息

            //同文件下
            //Assembly assembly = Assembly.Load("反射");
            //不同文件下绝对路径
            //Assembly assembly = Assembly.LoadFrom("反射.dll");
            //相对路径
            //Assembly assembly = Assembly.LoadFrom("..\\反射.dll");

            // Type[] types = assembly.GetTypes();
            //GetType();传入名称，得到Type对象

            // 3.类库工程创建

            #endregion

            #region Activator
            ////用于快速获取程序集信息的类
            ////将Type对象快捷实例化对象，先得到Type对象，再通过Type对象得到Assembly对象
            //Type testType = typeof(Test);
            //// 1. 无参构造
            //Test testObj = Activator.CreateInstance(testType) as Test;
            //Console.WriteLine(testObj.str);
            //// 2. 有参构造,必须和构造函数参数类型一致
            //testObj = Activator.CreateInstance(testType, 99) as Test;
            //Console.WriteLine(testObj.str);
            #endregion

        }
    }
}
