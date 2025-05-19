using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Time 时间相关内容 主要用于游戏中参与位移、计时、时间暂停等

        // 1.时间缩放比例
        // -1时间停止
        Time.timeScale = 0;
        // -2恢复正常 
        Time.timeScale = 1;
        // -3时间2倍速
        Time.timeScale = 2;

        // 2.帧间隔时间
        // 最近的一帧用了多长时间，单位是秒
        //受Scale影响
        print("受Scale影响" + Time.deltaTime);
        //不受Scale影响
        print("不受Scale影响" + Time.unscaledDeltaTime);

        // 3.游戏开始到现在的时间.
        //受Scale影响
        print(Time.time);
        //不受Scale影响
        print(Time.unscaledTime);


        // 5.帧数
        // 从开始到现在游戏跑了多少帧
        print(Time.frameCount);

    }

    private void FixedUpdate()
    {
        // 4.物理帧间隔时间
        //受Scale影响
        print(Time.fixedDeltaTime);
        //不受Scale影响
        print(Time.fixedUnscaledDeltaTime);

    }


}
