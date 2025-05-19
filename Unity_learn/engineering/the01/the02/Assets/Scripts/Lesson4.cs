using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4 : MonoBehaviour
{
    // 准备用来克隆的对象
    // 可以是场景的一个对象或者是一个预设体对象,在unity关联
    public GameObject MyObj;
    // Start is called before the first frame update
    void Start()
    {
        #region GameObject中的成员变量
        // 名字
        print(this.gameObject.name);
        this.gameObject.name = "Lesson4改名";
        print(this.gameObject.name);
        //是否激活
        print(this.gameObject.activeSelf);
        //是否是静态
        print(this.gameObject.isStatic);
        //层级
        print(this.gameObject.layer);
        //标签
        print(this.gameObject.tag);
        //transform,和直接this一样

        #endregion


        #region GameObject中的静态方法
        // 创建自带几何体
        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obj.name = "创建的立方体";
        // 查找对象相关知识
        // ***无法找到失活的对象***

        //1查找单个对象
        // 如果场景中存在多个满足条件的对象，无法准确查找，只会随机返回一个
        //-通过对象名查找,效率低，因为要在整个场景中查找
        GameObject obj2 = GameObject.Find("lgs");
        if (obj2 != null)
        {
            print(obj2.name);
        }
        else
        {
            print("没找到");
        }
        //-通过tag(标签)来查找对象
        /*GameObject obj3 = GameObject.FindWithTag("Player");*/
        GameObject obj3 = GameObject.FindGameObjectWithTag("Player");
        if (obj3 != null)
        {
            print(obj3.name);
        }
        else
        {
            print("没找到");
        }
        //2查找多个对象
        // 找多个对象的api只能通过tag找，无法通过名字查找
        // 只能找到激活对象，无法找到失活对象
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Player");
        if(objs != null)
        {
            print(objs.Length);
        }

        // 实例化对象方法（克隆对象）方法
        // 根据GameObject对象创建一个一模一样的对象
        GameObject obj5 = GameObject.Instantiate(MyObj);
        // 继承了Mono就可以不写GameObject

        // 删除对象方法,参数二代表延迟删除的秒数
        GameObject.Destroy(obj5,5);
        // 不仅可以删除对象，还可以删除脚本
        Destroy(this);
        // 移除会在下一帧移除，为了避免卡顿
        // 立马移除方法：
        DestroyImmediate(MyObj);

        // 过场景不移除
        GameObject.DontDestroyOnLoad(this.gameObject);

        #endregion



        #region GameObject中的成员方法
        // 创建空物体
        // new 就是创建一个空物体，参数是命名，后面变长参数是脚本
        GameObject obj6 = new GameObject("空物体",typeof(lesson3),typeof(lesson2));

        // 为对象添加脚本
        lesson2 les2 = obj6.AddComponent(typeof(lesson2)) as lesson2;
        les2 = obj6.AddComponent<lesson2>();

        // 得到脚本的方法和继承Mono的类得到脚本的方法一模一样


        // 标签比较两种方法
        if (this.gameObject.CompareTag("Player"))
        {
            print("对象的标签是Player");
        }

        if (this.gameObject.tag == "Player")
        {
            print("对象的标签是Player");
        }

        // 设置激活失活
        obj6.SetActive(true);
        obj6.SetActive(false);


        // 次要的成员方法

        // 广播命名某对象执行方法，方法会在该对象挂载的所有脚本中查找。方法参数会在函数名后当做参数传入
        // 所有名称相同的方法都会被执行。效率很低
        this.gameObject.SendMessage("方法名","函数的参数");

        // 向自己和子对象广播
        this.gameObject.BroadcastMessage("方法名", "函数的参数");

        // 向自己和父对象广播
        this.gameObject.SendMessageUpwards("方法名", "函数的参数");




        #endregion

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
