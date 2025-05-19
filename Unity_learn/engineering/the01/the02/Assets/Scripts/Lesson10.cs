using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 世界坐标转本地坐标
        // 可以帮助我们大概判断相对位置，用处较少
        //世界坐标系的点转换为本地坐标系的点，受到缩放影响
        print("点为" + this.transform.InverseTransformPoint(Vector3.forward));

        //世界坐标系的方向转换为本地坐标系的方法
        //不受缩放影响
        print("不受" + this.transform.InverseTransformDirection(Vector3.forward));
        //受缩放影响
        print("受" + this.transform.InverseTransformVector(Vector3.forward));
        #endregion

        #region 本地坐标转世界坐标
        //本地坐标系的点转换为世界坐标系的点，受到缩放影响
        print("本地 点" + this.transform.TransformPoint(Vector3.forward));
        //本地坐标系的方向转换为世界坐标系的方法
        //不受缩放影响
        print("本地 方向不受缩放影响" + this.transform.TransformDirection(Vector3.forward));
        //受缩放影响
        print("本地 方向受缩放影响" + this.transform.TransformVector(Vector3.forward));
        #endregion

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
