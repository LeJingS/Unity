using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 进阶
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList
            //申明
            ArrayList list = new ArrayList();
            //添加
            list.Add("张三");
            list.AddRange(new string[] { "李四", "王五" });
            //删
            list.Remove("张三");//删除第一个找到的张三
            list.RemoveAt(0);//删除索引为0的元素
            list.Clear();//清空
            //查
            string str = list[0].ToString();//获取索引为0的元素
            list.Contains(str);//判断是否包含
            list.IndexOf(str);//正向获取索引，-1表示没有
            list.LastIndexOf(str);//反向获取索引，-1表示没有
            //改
            list[0] = "张三";
            //长度
            int l = list.Count;
            //容量
            int c = list.Capacity;
            //由于基于object，所以存在装箱拆箱，耗性能
            #endregion

            #region Stack
            // 栈
            // 申明
            Stack stack = new Stack();
            //增
            stack.Push("张三");
            //取
            stack.Pop();//删除并返回栈顶元素
            stack.Clear();//清空
            //查
            string str2 = stack.Peek().ToString();//获取栈顶元素，不删除
            stack.Contains(str);//判断是否包含
            //改，无法改。只能清空
            //遍历
            foreach (object item in stack)
            {
                Console.WriteLine(item);
            }
            //长度
            int l2 = stack.Count;
            //由于基于object，所以存在装箱拆箱，耗性能
            #endregion

            #region Queue
            // 队列
            // 申明
            Queue queue = new Queue();
            //增
            queue.Enqueue("张三");
            //取
            queue.Dequeue();
            queue.Clear();
            //查
            string str3 = queue.Peek().ToString();
            queue.Contains(str);
            //改，无法改。只能清空
            //遍历
            foreach (object item in queue)
            {
                Console.WriteLine(item);
            }
            //长度
            int l3 = queue.Count;
            //由于基于object，所以存在装箱拆箱，耗性能
            #endregion

            #region Hashtable
            // 哈希表，键值对，不能出现重复的键
            // 申明
            Hashtable hashtable = new Hashtable();
            //增
            hashtable.Add("张三", 18);
            //删，只能通过键删除
            hashtable.Remove("张三");
            hashtable.Clear();
            //查,通过键获取值
            Console.WriteLine(hashtable["张三"]);
            // 查看是否存在
            hashtable.ContainsKey("张三");
            //根据值检测
            hashtable.ContainsValue(18);
            //改，只能通过键修改值
            hashtable["张三"] = 19;
            //遍历
            // 键值对遍历
            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
            //键遍历
            foreach (string key in hashtable.Keys)
            {
                Console.WriteLine(key + ":" + hashtable[key]);
            }
            //值遍历
            foreach (object value in hashtable.Values)
            {
                Console.WriteLine(value);
            }
            //迭代器遍历法

            //装箱拆箱损耗    
            #endregion

            #region List
            List<int> list2 = new List<int>();
            //增
            list2.Add(1);
            //删
            list2.Remove(1);//删除第一个找到的1
            list2.RemoveAt(0);//删除索引为0的元素
            list2.Clear();//清空
            //改
            list2[0] = 1;
            //查
            list2.Contains(1);//判断是否包含
            list2.IndexOf(1);//正向获取索引，-1表示没有
            list2.LastIndexOf(1);//反向获取索引，-1表示没有
            //遍历
            foreach (int item in list2)
            {
                Console.WriteLine(item);
            }
            for(int i = 0; i < list2.Count; i++)
            {
                Console.WriteLine(list2[i]);
            }
            //长度
            int l4 = list2.Count;
            //容量
            int c2 = list2.Capacity;
            list2.Reverse();//倒序
            list2.Sort();//排序


            #endregion

            #region Dictionary
            // 字典，键值对，可以出现重复的键
            // 申明
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            //增
            dictionary.Add("张三", 18);
            //删，只能通过键删除
            dictionary.Remove("张三");
            dictionary.Clear();
            //查,通过键获取值
            Console.WriteLine(dictionary["张三"]);
            // 查看是否存在
            dictionary.ContainsKey("张三");
            //根据值检测
            dictionary.ContainsValue(18);
            //改，只能通过键修改值
            dictionary["张三"] = 19;
            //遍历
            // 键值对遍历
            foreach (KeyValuePair<string, int> item in dictionary)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
            #endregion

            #region LinkedList
            // 申明
            LinkedList<int> linkedList = new LinkedList<int>();
            //增
            linkedList.AddFirst(1);//添加到链表头部
            linkedList.AddLast(2);//添加到链表尾部
            linkedList.AddAfter(linkedList.First, 3);//添加到指定节点之后
            linkedList.AddBefore(linkedList.Last, 4);//添加到指定节点之前
            //删
            linkedList.RemoveFirst();//删除头节点
            linkedList.RemoveLast();//删除尾节点
            linkedList.Remove(3);//删除指定节点
            linkedList.Remove(linkedList.First);//删除指定节点
            linkedList.Remove(linkedList.Last);//删除指定节点
            linkedList.Clear();//清空
            //改
            linkedList.First.Value = 1;//修改头节点的值
            linkedList.Last.Value = 2;//修改尾节点的值
            //查
            linkedList.Contains(1);//判断是否包含
            //遍历
            foreach (int item in linkedList)
            {
                Console.WriteLine(item);
            }
            //长度
            int l5 = linkedList.Count;
            //迭代器遍历法
            foreach (int node in linkedList)
            {
                Console.WriteLine(node);
            }
            #endregion



        }
    }
    #region 泛型
    class TestClass<T, U, V>
    {
        public T t;
    }
    #endregion
}
