using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson9 : MonoBehaviour
{
    public Transform son;
    // Start is called before the first frame update
    void Start()
    {
        #region 获取和设置父对象
        /*//获取父对象

        print(this.transform.parent.name);
        //设置父对象
        // 断绝
        this.transform.parent = null;
        // 继承
        this.transform.parent = GameObject.Find("father2").transform;

        //设置api
        // 参数1 新父对象的transform
        // 参数2 是否保留世界坐标的 位置 角度 缩放 信息
        this.transform.SetParent(null);
        // true 会保留世界坐标下的状态 和父对象进行计算得到本地坐标系的信息
        // false 会直接赋值到本地坐标系下，视图中的位置和缩放会发生变化*/
        #endregion

        #region 抛妻弃子

        //this.transform.DetachChildren();
        //  只能影响自己的子对象，不能迭代往后影响
        #endregion

        #region 获取子对象
        // 按名字来查找子对象,可以找到失活的对象，只能找到自己的子对象，不能继续往下
        // 返回transform
        print(this.transform.Find("Cube").name);
        // 遍历子对象
        // 得到数量，失活也算，同样不能往下
        print(this.transform.childCount);
        for(int i =0;i<this.transform.childCount;i++)
        {
            // 通过索引来得到对应的子对象
            print(this.transform.GetChild(i).name);
        }
        #endregion

        #region 儿子的操作
        // 找到自己是否是某个对象的子对象
        if (son.IsChildOf(this.gameObject.transform))
        {
            print("子对象的名字是" + son.name);
        }
        //得到自己作为子对象的编号
        print(son.GetSiblingIndex());
        //把自己的编号设为0
        son.SetAsFirstSibling();
        //把自己的编号设为最后一个
        son.SetAsLastSibling();
        //把自己的编号设为指定值,溢出不会报错，负数不会报错，都会设置为最后一个
        son.SetSiblingIndex(9);
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
