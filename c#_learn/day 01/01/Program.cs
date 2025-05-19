using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    enum E_自定义枚举名称
    {
        E_枚举值1 = 0,
        E_枚举值2,
        E_枚举值3
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            E_自定义枚举名称 e = E_自定义枚举名称.E_枚举值1;
            
            string str = E_自定义枚举名称.E_枚举值1.ToString();
            Console.WriteLine(str+'n'+E_自定义枚举名称.E_枚举值1+'n'+e);
            Console.ReadKey();
            
        }
    }
}
