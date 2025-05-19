using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 多线程
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(newThreadLogic);
            t.Start();

            //设置为后台线程，不会阻塞主线程
            t.IsBackground = true;
            //关闭一个线程，用变量把死循环停止。注意，在.Net core 中，不能使用Abort()方法来关闭线程，否则会报错。
            t.Abort();
            //线程休眠，让主线程休眠1秒，在哪个线程编写，哪个线程休眠。
            Thread.Sleep(1000);
            //线程数据共享，线程锁 lock(信号引用变量)
            lock (t) { 
            // 线程锁执行逻辑
            }


        }
        static void newThreadLogic()
        {
            //新线程逻辑
            while (true) { Console.WriteLine("new thread"); }
            
        }
    }
}
