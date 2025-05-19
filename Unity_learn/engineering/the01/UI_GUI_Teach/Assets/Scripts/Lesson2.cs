using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson2 : MonoBehaviour
{
    public Texture tex;
    public GUIContent content;
    public GUIStyle style;
    // Start is called before the first frame update
    //gui空间绘制的共同点：都是静态函数，参数都大同小异
    /*
     位置参数 Rect参数 x y 位置 h 尺寸
    显示文本 string参数
    图片信息 Texture参数
    综合信息 GUIContent参数
    自定义样式 GUIStyle参数
     */


    private void OnGUI()
    {
        //文本控件基本使用
        GUI.Label(new Rect(0, 0, 100, 20), "LeJingS");
        GUI.Label(new Rect(0, 30, 100, 20), tex);
        //综合使用
        GUI.Label(new Rect(0, 30, 100, 20), content);
        //自定义样式改字体改大小等
        GUI.Label(new Rect(0, 30, 100, 20),"lejings_style", style);

        //按钮控件
        GUI.Button(new Rect(40, 30, 100, 20), content);

    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
