using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lesson3 : MonoBehaviour
{
    public lesson3 otherLesson3;
    // Start is called before the first frame update
    void Start()
    {
        // 1. 获取GameObject的信息
        print(this.gameObject.name);
        // 2. 获取位置信息
        print(this.transform.position);
        // 角度
        print(this.transform.eulerAngles);
        // 大小
        print(this.transform.lossyScale);

        // 获取和设置脚本激活状态
        this.enabled = false;

        // 获取别的脚本对象 依附的 gameObject 和 transform位置信息
        print(otherLesson3.gameObject.name);
        print(otherLesson3.transform.position);
        // 获取别的脚本对象

        #region 重要方法
        // 得到依附对象上挂载的其它脚本
        //1.得到自己挂载的单个脚本
        // 根据脚本名获取,没有对应的脚本则返回空
        lesson3_Test t = this.GetComponent("lesson3_Test") as lesson3_Test;
        print(t);
        //根据Type获取
        t = this.GetComponent(typeof(lesson3_Test)) as lesson3_Test;
        print(t);
        // 根据泛型获取（不用二次转换）
        t = this.GetComponent<lesson3_Test>();
        print(t);
        //2.得到自己挂载的多个脚本
        lesson3[] array = this.GetComponents<lesson3>();
        print(array.Length);

        List<lesson3> list = new List<lesson3>();
        this.GetComponents<lesson3>(list);
        print(list.Count);
        //3.得到子(后代都算)对象挂载的脚本(默认也会找自己身上是否挂载了此脚本)
        t = this.GetComponentInChildren<lesson3_Test>(true);
        // true 表示子对象即使失活了也寻找，默认是false
        print(t);

        
        lesson3_Test[] lts = this.GetComponentsInChildren<lesson3_Test>(true);
        print(lts.Length);

        List<lesson3_Test> list2 = new List<lesson3_Test>();
        this.GetComponentsInChildren<lesson3_Test>(true,list2);
        print(list2.Count);
        //4.得到父（前代都算）对象挂载的脚本(默认也会找自己身上是否挂载了此脚本)
        t = this.GetComponentInParent<lesson3_Test>();
        print(t);

        lts = this.GetComponentsInParent<lesson3_Test>();
        // 省略List版本
        //5.尝试获取脚本
        // 提供一个更加安全的获取单个脚本的方法，如果得到了会返回 true 反正空错误
        lesson3_Test l3t;
        if(this.TryGetComponent<lesson3_Test>(out l3t))
        {

        }
        

        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        print("1");
    }
}
