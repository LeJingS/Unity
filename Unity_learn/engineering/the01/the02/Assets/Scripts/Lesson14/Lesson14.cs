using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson14 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //1.重要的静态成员
        //获取摄像机
        //主摄像机的获取,必须有一个摄像机的表识为MainCamera
        print(Camera.main.name);
        //得到场景上摄像机的数量
        print(Camera.allCamerasCount);
        //得到场景上所有摄像机的信息
        Camera[] all = Camera.allCameras;

        //渲染相关委托,摄像机剔除前的委托
        Camera.onPreCull += (c) =>
        {

        };

        //2.重要成员
        //界面上的参数都可以得到
        Camera.main.depth = 10;
        // 世界坐标转屏幕坐标
        Vector3 v = Camera.main.WorldToScreenPoint(this.transform.position);
        print(v);
        


    }

    // Update is called once per frame
    void Update()
    {
        // 屏幕坐标转世界坐标
        Vector3 v = Input.mousePosition;
        v.z = 10;
        print(Camera.main.ScreenToWorldPoint(v));
    }
}
