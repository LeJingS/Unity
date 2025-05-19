using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _02_扩展方法
{
    #region 扩展方法
    static class Tools
    {
        //为int类型添加一个SpeakValue方法
        public static void SpeakValue(this int value)
        {
            Console.WriteLine(value);
        }
    }

    #endregion
    internal class Program
    {


        static void Main(string[] args)
        {
            int i = 10;
            i.SpeakValue();
        }
    }
}
