using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 1.缩放
        // 相对世界坐标系
        print(this.transform.lossyScale);

        // 本地坐标系
        print(this.transform.localScale);

        // 缩放不能只改xyz，且相对于世界坐标系的缩放大小只能得不能改
        // 没有更改的相关api

        // 2.看向
        //让一个对象的面朝向一直看向一个点或者一个对象(面即z轴正方向)
        this.transform.LookAt(Vector3.zero);
        //看向对象的参数是该对象的transform
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
