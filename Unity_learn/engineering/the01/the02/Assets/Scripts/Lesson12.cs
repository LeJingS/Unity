using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson12 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //1.静态属性
        //常用
        //当前电脑屏幕分辨率
        print(Screen.currentResolution.width+"*"+Screen.currentResolution.height);

        //电子窗口当前宽高
        print(Screen.width + " " + Screen.height);

        //屏幕休眠模式,设为永不息屏
        Screen.sleepTimeout = SleepTimeout.NeverSleep;

        //2.静态方法
        //设置分辨率,是否全屏，pc常用
        Screen.SetResolution(1920, 1080, false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
