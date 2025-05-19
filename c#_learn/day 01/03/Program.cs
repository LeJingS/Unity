using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //申明
           ArrayList array = new ArrayList();
            //增
            array.Add("张三");
            array.AddRange(new string[] { "李四", "王五" });
            //删
            array.Remove("张三");
            array.RemoveAt(0);

        }
    }
}
