using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson21 : MonoBehaviour
{
    AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        #region 1.获取设备麦克风信息
        string[] strs = Microphone.devices;
        for(int i = 0; i < strs.Length; i++)
        {
            print(strs[i]);
        }
        #endregion

        

        #region 4.获取音频数据用于存储或者传输
        //暂时不学
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        #region 2.开始录制
        //参数：1.设备名，传空使用默认设备
        //2.超过录制时长后是否重新录制
        //3.录制时长,秒
        //4.采样率
        clip = Microphone.Start(null, false, 10, 44100);
        #endregion

        #region 3.结束录制
        Microphone.End(null);
        #endregion
    }
}
