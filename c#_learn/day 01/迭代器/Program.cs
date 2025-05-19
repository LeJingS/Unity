using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 迭代器
{
    //自定义迭代器
    class CustomIterator : IEnumerable,IEnumerator
    {
        private int[] list;
        //定义的光标即索引
        private int index=-1;
        
        public CustomIterator()
        {
            list = new int[] { 0,1,2,3,4,5,6,7,8 };
        }

        // 实现IEnumerable接口的关键方法
        public IEnumerator GetEnumerator()
        {
            Reset();
            return this;
        }
        public object Current {
            get
            {
                return list[index];
            }
        }

        public bool MoveNext()
        {
            ++index;
            return index < list.Length;
        }
        public void Reset()
        {
            //重置光标
            index = -1;
        }
    }
    class CustomList
    {
        private int[] list;
    }

    //使用语法糖实现迭代器 yield return
    class CustomList2 : IEnumerable
    {
        private int[] list;

        public CustomList2()
        {
            list = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for(int i = 0; i < list.Length; i++)
            {
                // yield return 语句将返回一个值，并暂停当前方法
                yield return list[i];
            }
        }
    }





    internal class Program
    {
        static void Main(string[] args)
        {
            CustomIterator list = new CustomIterator();
            //foreach本质
            //1.先获取in后面对象的IEnumerator方法
            //2.调用IEnumerator的MoveNext方法(移动光标到下一个位置)
            //3.调用IEnumerator的Current属性(获取当前位置的值给item)
            //4.如果MoveNext返回false,则结束循环

            foreach (int item in list)
            {
                Console.WriteLine(item);


            }
            
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
