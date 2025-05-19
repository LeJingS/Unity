using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson20 : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = this.GetComponent<AudioSource>();




        #region 3.如何动态控制音效播放
        //1.直接在要播放的对象上挂载控制脚本
        //2.实例化挂在了音效源脚本的对象

        //3.用一个AudioSource来控制不同的音效
        AudioSource aus = this.gameObject.AddComponent<AudioSource>();
        aus.clip = clip;
        aus.Play();
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        #region 1.代码控制播放停止
        if (Input.GetKeyDown(KeyCode.P))
        {
            //播放,
            /*延迟播放
             参数为秒数
            PlayDelayer();
             */
            audioSource.Play();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            //停止
            audioSource.Stop();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //暂停
            audioSource.Pause();
        }
        #endregion

        #region 2.如何检测音效播放完毕
        if (audioSource.isPlaying)
        {
            print("播放结束");
        }
        else
        {
            print("正在播放");
        }
        #endregion
    }
}
